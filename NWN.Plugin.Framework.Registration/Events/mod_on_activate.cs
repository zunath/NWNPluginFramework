using Core;
using NWN.Plugin.Framework.Registration;
using static NWN.NWScript;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
    class mod_on_activate
    {
        // ReSharper disable once UnusedMember.Local
        private static void Main()
        {
            PluginRegistrar.RunRegisteredEvents(RegistrationEventType.OnModuleActivateItem);
        }
    }
}
