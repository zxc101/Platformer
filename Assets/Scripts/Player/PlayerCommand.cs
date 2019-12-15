using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerCommand
{
    protected PlayerManager player;
    public abstract void Command();

    protected float Direction()
    {
        return player.Transform.rotation.y == 0 ? 1 : -1;
    }
}
