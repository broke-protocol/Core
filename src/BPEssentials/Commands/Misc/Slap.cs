﻿using BPEssentials.Abstractions;
using BPEssentials.ExtensionMethods;
using BrokeProtocol.Utility;
using BrokeProtocol.Entities;
using BrokeProtocol.Required;

namespace BPEssentials.Commands
{
    public class Slap : Command
    {
        public void Invoke(ShPlayer player, ShPlayer target)
        {
            var amount = new System.Random().Next(4, 15);
            target.svPlayer.Damage(DamageIndex.Null, amount, null, null);
            target.svPlayer.SvForce(new UnityEngine.Vector3(500f, 0f, 500f));
            target.TS("target_slap", player.username.CleanerMessage(), amount.ToString());
            player.TS("player_slap", target.username.CleanerMessage(), amount.ToString());
        }
    }
}
