using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public IPlayerState myCurrentState;

    // Start is called before the first frame update
    void Start()
    {
        myCurrentState = new StandingPlayerState();    
    }

    // Update is called once per frame
    void Update()
    {
        myCurrentState.Execute(this);
    }
}
