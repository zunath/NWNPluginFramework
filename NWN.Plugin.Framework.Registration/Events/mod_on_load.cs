using System;
using Core;
using NWN.Plugin.Framework.Registration;
using static NWN.NWScript;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
    class mod_on_load
    {
        // ReSharper disable once UnusedMember.Local
        private static void Main()
        {
            PluginRegistrar.LoadPlugins();

            SetEventScript(GetModule(), EVENT_SCRIPT_MODULE_ON_ACQUIRE_ITEM, "mod_on_acquire");
            SetEventScript(GetModule(), EVENT_SCRIPT_MODULE_ON_ACTIVATE_ITEM, "mod_on_activate");
            SetEventScript(GetModule(), EVENT_SCRIPT_MODULE_ON_CLIENT_ENTER, "mod_on_enter");
            SetEventScript(GetModule(), EVENT_SCRIPT_MODULE_ON_CLIENT_EXIT, "mod_on_leave");
            SetEventScript(GetModule(), EVENT_SCRIPT_MODULE_ON_PLAYER_CANCEL_CUTSCENE, "mod_on_csabort");
            SetEventScript(GetModule(), EVENT_SCRIPT_MODULE_ON_HEARTBEAT, "mod_on_heartbeat");
            SetEventScript(GetModule(), EVENT_SCRIPT_MODULE_ON_PLAYER_CHAT, "mod_on_chat");
            SetEventScript(GetModule(), EVENT_SCRIPT_MODULE_ON_PLAYER_DEATH, "mod_on_death");
            SetEventScript(GetModule(), EVENT_SCRIPT_MODULE_ON_PLAYER_DYING, "mod_on_dying");
            SetEventScript(GetModule(), EVENT_SCRIPT_MODULE_ON_EQUIP_ITEM, "mod_on_equip");
            SetEventScript(GetModule(), EVENT_SCRIPT_MODULE_ON_PLAYER_LEVEL_UP, "mod_on_levelup");
            SetEventScript(GetModule(), EVENT_SCRIPT_MODULE_ON_RESPAWN_BUTTON_PRESSED, "mod_on_respawn");
            SetEventScript(GetModule(), EVENT_SCRIPT_MODULE_ON_PLAYER_REST, "mod_on_rest");
            SetEventScript(GetModule(), EVENT_SCRIPT_MODULE_ON_UNEQUIP_ITEM, "mod_on_unequip");
            SetEventScript(GetModule(), EVENT_SCRIPT_MODULE_ON_LOSE_ITEM, "mod_on_unacquire");
            SetEventScript(GetModule(), EVENT_SCRIPT_MODULE_ON_USER_DEFINED_EVENT, "mod_on_user");
            
            PluginRegistrar.RunRegisteredEvents(RegistrationEventType.OnModuleLoad);
        }
    }
}
