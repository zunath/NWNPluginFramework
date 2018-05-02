using static NWN.NWScript;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{ 
    class mod_on_enter
    {
        // ReSharper disable once UnusedMember.Local
        private static void Main()
        {
            ExecuteScript("x3_mod_def_enter", Object.OBJECT_SELF);
        }
    }
}
