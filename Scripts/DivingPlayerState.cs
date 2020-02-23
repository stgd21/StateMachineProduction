using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivingPlayerState : IPlayerState
{
    public void Enter(Player player)
    {
        Debug.Log("Entered Diving");
        player.myCurrentState = this;
        player.transform.localScale = new Vector3(1, 1.5f, 1);
        //Rigidbody rb = player.GetComponent<Rigidbody>();
        //rb.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
    }

    public void Execute(Player player)
    {
        if (Physics.Raycast(player.transform.position, Vector3.down, 1f))
        {
            player.transform.localScale = Vector3.one;
            StandingPlayerState standingState = new StandingPlayerState();
            standingState.Enter(player);
        }
    }
}