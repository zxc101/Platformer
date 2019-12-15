using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunCommand : PlayerCommand
{
    public RunCommand(PlayerManager _player)
    {
        player = _player;
    }

    public override void Command()
    {
        Run();
    }

    private void Run()
    {
        if (player.Anim != null)
        {
            player.Anim.SetFloat("Speed", 1);
            player.Transform.Translate(player.Transform.right * Direction() * player.Speed * Time.deltaTime);
        }
    }
}
