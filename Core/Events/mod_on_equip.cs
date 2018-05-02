using static NWN.NWScript;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
    class mod_on_equip
    {
        // ReSharper disable once UnusedMember.Local
        static void Main()
        {
            ExecuteScript("x2_mod_def_equ", Object.OBJECT_SELF);
        }
    }
}
