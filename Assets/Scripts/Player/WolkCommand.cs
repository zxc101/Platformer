using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolkCommand : PlayerCommand
{
    public WolkCommand(PlayerManager _player)
    {
        player = _player;
    }

    public override void Command()
    {
        Wolk();
    }

    private void Wolk()
    {
        if (player.Anim != null)
        {
            player.Anim.SetFloat("Speed", 0.5f);
            Debug.Log(Direction());
            player.Transform.Translate(player.Transform.right * Direction() * player.Speed * 0.5f * Time.deltaTime);
        }
    }
}
