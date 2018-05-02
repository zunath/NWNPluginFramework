using NWN.Plugin.Framework;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
    internal class mod_on_csabort
    {
        // ReSharper disable once UnusedMember.Local
        private static void Main()
        {
            PluginRegistrar.RunRegisteredEvents(RegistrationEventType.OnModuleCutsceneAbort);
        }
    }
}
