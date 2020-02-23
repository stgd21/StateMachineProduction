using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckingPlayerState : IPlayerState
{
    public void Enter(Player player)
    {
        Debug.Log("Entered Ducking");
        player.myCurrentState = this;
        Rigidbody rb = player.GetComponent<Rigidbody>();
        rb.transform.localScale *= 0.5f;
    }

    public void Execute(Player player)
    {
        if (!Input.GetKey(KeyCode.S))
        {
            //transition to standing
            StandingPlayerState standingState = new StandingPlayerState();
            Rigidbody rb = player.GetComponent<Rigidbody>();
            rb.transform.localScale *= 2.0f;
            standingState.Enter(player);
        }
    }
}
