using Core;
using NWN.Plugin.Framework.Registration;
using static NWN.NWScript;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
    class mod_on_equip
    {
        // ReSharper disable once UnusedMember.Local
        static void Main()
        {
            PluginRegistrar.RunRegisteredEvents(RegistrationEventType.OnModuleEquipItem);
        }
    }
}
