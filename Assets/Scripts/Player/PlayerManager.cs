using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed;

    private Animator anim;

    private PlayerCommand idle;
    private PlayerCommand wolk;
    private PlayerCommand run;
    private PlayerCommand jump;

    public Transform Transform => player;
    public Animator Anim => anim;
    public float Speed => speed;

    private void Start()
    {
        TryGetAnim();
        idle = new IdleCommand(this);
        wolk = new WolkCommand(this);
        run = new RunCommand(this);
        jump = new JumpCommand(this);
    }

    public void TryGetAnim()
    {
        if (player.GetComponent<Animator>() != null)
        {
            anim = player.GetComponent<Animator>();
        }
        else
        {
            Debug.Log("Player isn't have component Animator.");
        }
    }

    public void Idle() => idle.Command();
    public void Wolk() => wolk.Command();
    public void Run() => run.Command();
    public void Jump() => jump.Command();

    public void RotateLeft() => Rotate(0, 180, 0);
    public void RotateRight() => Rotate(0, 0, 0);
    private void Rotate(float x, float y, float z) => player.rotation = Quaternion.Euler(x, y, z);
}
