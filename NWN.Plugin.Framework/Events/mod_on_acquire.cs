using Core;
using NWN.Plugin.Framework.Registration;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
    internal class mod_on_acquire
    {
        // ReSharper disable once UnusedMember.Local
        private static void Main()
        {
            PluginRegistrar.RunRegisteredEvents(RegistrationEventType.OnModuleAcquireItem);
        }
    }
}