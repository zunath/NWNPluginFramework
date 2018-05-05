namespace NWN.Plugin.Framework
{
    public interface IPluginRegistration
    {
        void OnRegisterPlugin();
        void OnShutdown();

        void OnModuleAcquireItem();
        void OnModuleActivateItem();
        void OnModuleChat();
        void OnModuleCutsceneAbort();
        void OnModuleDeath();
        void OnModuleDying();
        void OnModuleEnter();
        void OnModuleEquipItem();
        void OnModuleHeartbeat();
        void OnModuleLeave();
        void OnModuleLevelUp();
        void OnModuleLoad();
        void OnModuleRespawn();
        void OnModuleRest();
        void OnModuleUnacquireItem();
        void OnModuleUnequipItem();
        void OnModuleUserDefined();
    }
}
