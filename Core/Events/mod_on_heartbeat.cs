using System;
using System.Reflection;
using static NWN.NWScript;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
    public class mod_on_heartbeat
    {
        // ReSharper disable once UnusedMember.Local
        private static void Main()
        {
            Console.WriteLine("Firing from C# again");
            //SendMessageToPC(GetFirstPC(), "Hello from C#");
        }

    }
}
