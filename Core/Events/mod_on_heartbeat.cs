using System;
using PluginTest;
using static NWN.NWScript;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
    public class mod_on_heartbeat
    {
        // ReSharper disable once UnusedMember.Local
        private static void Main()
        {
            Console.WriteLine("Firing from C#");
            //SendMessageToPC(GetFirstPC(), "Hello from C#");
            
            MyPlugin mp = new MyPlugin();

            mp.Test();
        }
        
    }
}
