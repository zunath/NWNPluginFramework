using Core;
using NWN.Plugin.Framework.Registration;
using static NWN.NWScript;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
    public class mod_on_acquire
    {
        // ReSharper disable once UnusedMember.Local
        private static void Main()
        {
            PluginRegistrar.RunRegisteredEvents(RegistrationEventType.OnModuleAcquireItem);
        }
    }
}