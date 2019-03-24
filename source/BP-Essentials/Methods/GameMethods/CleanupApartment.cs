﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using static BP_Essentials.Variables;
using static BP_Essentials.HookMethods;
using System.Reflection;

namespace BP_Essentials
{
    class CleanupApartment
    {
        public static void Run(ShPlayer shPlayer)
        {
            try
            {
                if (shPlayer == null)
                    return;
                typeof(SvPlayer).GetMethod(nameof(CleanupApartment), BindingFlags.NonPublic | BindingFlags.Instance).Invoke(shPlayer.svPlayer, new object[] { });
            }
            catch (Exception ex)
            {
                ErrorLogging.Run(ex);
            }
        }
    }
}
