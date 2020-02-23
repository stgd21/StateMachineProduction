using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayerState : IPlayerState
{
    public void Enter(Player player)
    {
        player.GetComponent<MeshRenderer>().material.color = Color.red;
        Debug.Log("Entered Red");
        player.myCurrentState = this;
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //transition to ducking
            DuckingPlayerState duckingState = new DuckingPlayerState();
            duckingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpingPlayerState jumpingState = new JumpingPlayerState();
            jumpingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            GreenPlayerState greenState = new GreenPlayerState();
            greenState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            BluePlayerState blueState = new BluePlayerState();
            blueState.Enter(player);
        }
    }
}
