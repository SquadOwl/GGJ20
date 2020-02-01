using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Move : NetworkBehaviour
{

    
    public float speed = 2f;

    
    private Rigidbody rb;

    
    private float dir;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!isLocalPlayer)
        {
            // exit from update if this is not the local player
            return;
        }

        dir = Input.GetAxis("Horizontal");

        // handle player input for movement

        rb.velocity = new Vector3(speed * dir, 0, 0);

    }
}
