using Core;
using NWN.Plugin.Framework.Registration;
using static NWN.NWScript;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
    class mod_on_levelup
    {
        // ReSharper disable once UnusedMember.Local
        static void Main()
        {
            PluginRegistrar.RunRegisteredEvents(RegistrationEventType.OnModuleLevelUp);
        }
    }
}
