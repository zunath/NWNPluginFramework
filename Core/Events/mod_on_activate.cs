using static NWN.NWScript;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
    class mod_on_activate
    {
        // ReSharper disable once UnusedMember.Local
        private static void Main()
        {
            ExecuteScript("x2_mod_def_act", Object.OBJECT_SELF);
        }
    }
}
