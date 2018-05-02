namespace Registration
{
    public interface IModuleRegistration
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
        void OnModuleLeave();
        void OnModuleLevelUp();
        bool OnModuleLoad(string[] args);
        void OnModuleRespawn();
        void OnModuleRest();
        void OnModuleUnacquireItem();
        void OnModuleUnequipItem();
        void OnModuleUserDefined();
    }
}
