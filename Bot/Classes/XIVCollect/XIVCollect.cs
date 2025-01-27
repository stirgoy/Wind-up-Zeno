﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    internal static class XIV_Collect
    {
        internal static class Apis
        {
            internal static string Users { get => "https://ffxivcollect.com/api/users/"; }
            internal static string Character { get => "https://ffxivcollect.com/api/characters/"; }
            internal static string Minion { get => "https://ffxivcollect.com/api/minions?name_en_start="; }
            internal static string Mount { get => "https://ffxivcollect.com/api/mounts?name_en_start="; }
            internal static string Outfit { get => "https://ffxivcollect.com/api/outfits?name_en_start="; }

        }
    }
}
