using System;
using Registration;

namespace PluginTest
{
    public class ModuleRegistration: IModuleRegistration
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

        public void OnModuleLeave()
        {
            
        }

        public void OnModuleLevelUp()
        {
            
        }

        public bool OnModuleLoad(string[] args)
        {
            Console.WriteLine("Hello from my module registration");

            return true;
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
    }
}
