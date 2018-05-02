using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Registration;

namespace Core
{
    class PluginRegistrar
    {
        private readonly Dictionary<RegistrationEventType, List<Func<string[], bool>>> _registeredEvents;

        public PluginRegistrar()
        {
            _registeredEvents = new Dictionary<RegistrationEventType, List<Func<string[], bool>>>();

            var values = Enum.GetValues(typeof(RegistrationEventType)).Cast<RegistrationEventType>();
            foreach (var val in values)
            {
                _registeredEvents.Add(val, new List<Func<string[], bool>>());
            }

        }

        public void LoadPlugins()
        {
            string directory = Path.GetDirectoryName(Assembly.GetAssembly(typeof(PluginRegistrar)).Location);
            Console.WriteLine("Looking for plugins in: " + directory);

            if (string.IsNullOrWhiteSpace(directory)) return;

            List<string> plugins = Directory.GetFiles(directory).ToList();
            string[] exclusions = {"NWNPluginFramework.dll", "Core.dll"};
            
            for(int index = plugins.Count-1; index >= 0; index--)
            {
                string plugin = plugins[index];

                if (exclusions.Contains(Path.GetFileName(plugin)))
                {
                    Console.WriteLine("Excluding plugin: " + plugin);
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
                        IModuleRegistration registration = (IModuleRegistration)Activator.CreateInstance(type);
                        _registeredEvents[RegistrationEventType.OnModuleLoad].Add(registration.OnModuleLoad);
                    }
                }
            }
        }

        public void RunRegisteredEvents(RegistrationEventType type)
        {
            var registrations = _registeredEvents[type];

            foreach (var registration in registrations)
            {
                registration.Invoke(null);
            }
        }
    }
}
