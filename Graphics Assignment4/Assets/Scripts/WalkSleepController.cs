using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkSleepController : MonoBehaviour
{


    private Rigidbody rb;
    private int frame;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        frame = 0;
    }

    // Update is called once per frame
    void Update()
    {
        frame++;
        print(frame);

        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");

        float moveX = inputH * 50f;
        float moveZ = inputV * 150f;
        float moveY = 0f;
        if(frame == 50)
        {
            transform.Rotate(new Vector3(0, 90, 0));
        }
        if (frame == 450)
        {
            transform.Translate(new Vector3(0, 1f, 0));
        }
        if(frame == 450)
        {
            transform.Rotate(new Vector3(0, -180, 0));
        }
        
        rb.AddForce(new Vector3(moveX, 0f, moveZ));


    }
}
