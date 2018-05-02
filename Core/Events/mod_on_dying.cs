using static NWN.NWScript;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
    class mod_on_dying
    {
        // ReSharper disable once UnusedMember.Local
        static void Main()
        {
            ExecuteScript("nw_o0_dying", Object.OBJECT_SELF);
        }
    }
}
