﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using static BP_Essentials.Variables;
using static BP_Essentials.HookMethods;

namespace BP_Essentials.Commands
{
    class Disconnect
    {
        public static void Run(SvPlayer player, string message)
        {
            string arg1 = GetArgument.Run(1, false, true, message);
            if (string.IsNullOrEmpty(arg1))
            {
                player.SendChatMessage(ArgRequired);
                return;
            }
            var currPlayer = GetShByStr.Run(arg1);
            if (currPlayer == null)
            {
                player.SendChatMessage(NotFoundOnline);
                return;
            }
            player.svManager.Disconnect(currPlayer.svPlayer.connection, DisconnectTypes.Normal);
            player.SendChatMessage($"<color={infoColor}>Disconnected</color> <color={argColor}>{currPlayer.username}</color><color={infoColor}>.</color>");
        }
    }
}
