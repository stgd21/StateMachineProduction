using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingPlayerState : IPlayerState
{
    public void Enter(Player player)
    {
        Debug.Log("Entered Standing");
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

        if (Input.GetKeyDown(KeyCode.R))
        {
            RedPlayerState redState = new RedPlayerState();
            redState.Enter(player);
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
