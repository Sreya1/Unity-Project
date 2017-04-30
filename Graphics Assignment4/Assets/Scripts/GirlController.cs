using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlController : MonoBehaviour {


    private Rigidbody rb;
    private int frame;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        frame = 0;
    }

    // Update is called once per frame
    void Update () {
        frame++;
        print(frame);
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");
        
        float moveY = 0.02f;
        float moveZ = inputV * 50f;

        if(frame == 200)
        {
            transform.Rotate(new Vector3(0, 90, 0));
        }
        if(frame >= 200)
        {
            moveY = -0.02f;
        }

        rb.AddForce(new Vector3(0f, moveY, moveZ));

    }
}
