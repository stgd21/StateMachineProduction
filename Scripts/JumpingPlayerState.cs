using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingPlayerState : IPlayerState
{
    public void Enter(Player player)
    {
        Debug.Log("Entered Jumping");
        player.myCurrentState = this;
        Rigidbody rb = player.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
    }

    public void Execute(Player player)
    {
        if (Physics.Raycast(player.transform.position, Vector3.down, 0.55f))
        {
            StandingPlayerState standingState = new StandingPlayerState();
            standingState.Enter(player);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            DivingPlayerState divingState = new DivingPlayerState();
            divingState.Enter(player);
        }
    }
}
