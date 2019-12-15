using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private PlayerManager player;

    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.A))
            {
                player.RotateLeft();
            }
            else
            {
                player.RotateRight();
            }
            if (Input.GetKeyDown(KeyCode.Space)) player.Jump();
            if (Input.GetKey(KeyCode.LeftShift)) player.Run();
            else player.Wolk();
        }
        else if (Input.GetKeyDown(KeyCode.Space)) player.Jump();
        else player.Idle();
    }
}
