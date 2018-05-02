using static NWN.NWScript;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
    class mod_on_unacquire
    {
        // ReSharper disable once UnusedMember.Local
        static void Main()
        {
            ExecuteScript("x2_mod_def_unaqu", Object.OBJECT_SELF);
        }
    }
}
