using NWN.Plugin.Framework;
using static NWN.NWScript;

namespace NWN.Plugin.AreaEvents
{
    public class PluginRegistration: IPluginRegistration
    {
        public void OnRegisterPlugin()
        {
        }

        public void OnShutdown()
        {
        }

        public void OnModuleAcquireItem()
        {
        }

        public void OnModuleActivateItem()
        {
        }

        public void OnModuleChat()
        {
        }

        public void OnModuleCutsceneAbort()
        {
        }

        public void OnModuleDeath()
        {
        }

        public void OnModuleDying()
        {
        }

        public void OnModuleEnter()
        {
        }

        public void OnModuleEquipItem()
        {
        }

        public void OnModuleHeartbeat()
        {
        }

        public void OnModuleLeave()
        {
        }

        public void OnModuleLevelUp()
        {
        }

        public void OnModuleLoad()
        {
            Object area = GetFirstArea();
            while (GetIsObjectValid(area) == TRUE)
            {
                SetEventScript(area, EVENT_SCRIPT_AREA_ON_ENTER, "area_on_enter");
                SetEventScript(area, EVENT_SCRIPT_AREA_ON_EXIT, "area_on_exit");
                SetEventScript(area, EVENT_SCRIPT_AREA_ON_HEARTBEAT, "area_on_hb");
                SetEventScript(area, EVENT_SCRIPT_AREA_ON_USER_DEFINED_EVENT, "area_on_user");

                area = GetNextArea();
            }
        }

        public void OnModuleRespawn()
        {
        }

        public void OnModuleRest()
        {
        }

        public void OnModuleUnacquireItem()
        {
        }

        public void OnModuleUnequipItem()
        {
        }

        public void OnModuleUserDefined()
        {
        }

        public void OnAreaEnter()
        {
        }

        public void OnAreaExit()
        {
        }

        public void OnAreaHeartbeat()
        {
        }

        public void OnAreaUserDefined()
        {
        }
    }
}
