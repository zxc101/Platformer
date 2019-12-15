using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleCommand : PlayerCommand
{
    public IdleCommand(PlayerManager _player)
    {
        player = _player;
    }

    public override void Command()
    {
        Idle();
    }

    private void Idle()
    {
        if (player.Anim != null)
        {
            player.Anim.SetFloat("Speed", 0);
        }
    }
}
