﻿using static NWN.NWScript;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
    public class mod_on_acquire
    {
        // ReSharper disable once UnusedMember.Local
        private static void Main()
        {
            ExecuteScript("x2_mod_def_aqu", Object.OBJECT_SELF);
        }
    }
}