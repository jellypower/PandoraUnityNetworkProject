using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerNetworkMovement : NetworkBehaviour {

    bool isCalled = false;

    private void Update()
    {
        if (isCalled == true)
        {
            GameObject player = GameObject.FindWithTag("Player");
            player.transform.position += Vector3.right;
            isCalled = false;
        }
    }

    public void CallTheMovement()
    {
        isCalled = true;
    }

}
