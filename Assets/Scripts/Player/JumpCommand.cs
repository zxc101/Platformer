using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : PlayerCommand
{
    public JumpCommand(PlayerManager _player)
    {
        player = _player;
    }

    public override void Command()
    {
        Jump();
    }

    private void Jump()
    {
        if (player.Anim != null)
        {
            player.Anim.SetTrigger("Jump");
        }
    }
}
