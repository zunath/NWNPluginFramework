using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Core;

namespace NWN.Plugin.Framework.Registration
{
    static class PluginRegistrar
    {
        private static readonly Dictionary<RegistrationEventType, List<Action>> _registeredEvents = new Dictionary<RegistrationEventType, List<Action>>();
        private static bool _isLoaded;
        
        public static void LoadPlugins()
        {
            if (_isLoaded)
            {
                throw new Exception("Plugins have already been loaded. Only call LoadPlugins one time on your module load event.");
            }

            var values = Enum.GetValues(typeof(RegistrationEventType)).Cast<RegistrationEventType>();
            foreach (var val in values)
            {
                _registeredEvents.Add(val, new List<Action>());
            }

            string directory = Path.GetDirectoryName(Assembly.GetAssembly(typeof(PluginRegistrar)).Location);
            
            if (string.IsNullOrWhiteSpace(directory)) return;
            
            Console.WriteLine("Looking for plugins in: " + directory);
            List<string> plugins = Directory.GetFiles(directory).ToList();
            string[] exclusions = {"NWN.Plugin.Framework.dll", "NWN.Plugin.Framework.Registration.dll"};
            
            for(int index = plugins.Count-1; index >= 0; index--)
            {
                string plugin = plugins[index];

                if (exclusions.Contains(Path.GetFileName(plugin)))
                {
                    plugins.Remove(plugin);
                }
                else
                {
                    Console.WriteLine("Loading plugin: " + plugin);

                    var dll = Assembly.LoadFrom(plugin);
                    
                    List<Type> registrationTypes = new List<Type>();
                    foreach (var x in dll.DefinedTypes)
                    {
                        foreach (var i in x.GetInterfaces())
                        {
                            if (i == typeof(IModuleRegistration))
                            {
                                registrationTypes.Add(x);
                            }
                        }
                    }
                    
                    foreach (var type in registrationTypes)
                    {
                        Console.WriteLine("instance = " + type.FullName);

                        IModuleRegistration registration = (IModuleRegistration)Activator.CreateInstance(type);
                        
                        _registeredEvents[RegistrationEventType.OnModuleAcquireItem].Add(registration.OnModuleAcquireItem);
                        _registeredEvents[RegistrationEventType.OnModuleActivateItem].Add(registration.OnModuleActivateItem);
                        _registeredEvents[RegistrationEventType.OnModuleChat].Add(registration.OnModuleChat);
                        _registeredEvents[RegistrationEventType.OnModuleCutsceneAbort].Add(registration.OnModuleCutsceneAbort);
                        _registeredEvents[RegistrationEventType.OnModuleDeath].Add(registration.OnModuleDeath);
                        _registeredEvents[RegistrationEventType.OnModuleDying].Add(registration.OnModuleDying);
                        _registeredEvents[RegistrationEventType.OnModuleEnter].Add(registration.OnModuleEnter);
                        _registeredEvents[RegistrationEventType.OnModuleEquipItem].Add(registration.OnModuleEquipItem);
                        _registeredEvents[RegistrationEventType.OnModuleHeartbeat].Add(registration.OnModuleHeartbeat);
                        _registeredEvents[RegistrationEventType.OnModuleLeave].Add(registration.OnModuleLeave);
                        _registeredEvents[RegistrationEventType.OnModuleLevelUp].Add(registration.OnModuleLevelUp);
                        _registeredEvents[RegistrationEventType.OnModuleLoad].Add(registration.OnModuleLoad);
                        _registeredEvents[RegistrationEventType.OnModuleRespawn].Add(registration.OnModuleRespawn);
                        _registeredEvents[RegistrationEventType.OnModuleRest].Add(registration.OnModuleRest);
                        _registeredEvents[RegistrationEventType.OnModuleUnacquireItem].Add(registration.OnModuleUnacquireItem);
                        _registeredEvents[RegistrationEventType.OnModuleUnequipItem].Add(registration.OnModuleUnequipItem);
                        _registeredEvents[RegistrationEventType.OnModuleUserDefined].Add(registration.OnModuleUserDefined);

                        registration.OnRegisterPlugin();
                    }
                }
            }

            _isLoaded = true;
        }

        public static void RunRegisteredEvents(RegistrationEventType type)
        {
            var registrations = _registeredEvents[type];

            Console.WriteLine(" reggys = " + registrations.Count);

            foreach (var registration in registrations)
            {
                registration.Invoke();
            }
        }
    }
}
