using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Animator ani;
    private Rigidbody rb;

    private float inputH;
    private float inputV;

	// Use this for initialization
	void Start () {
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {

        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");
        ani.SetFloat("inputH", inputH);
        ani.SetFloat("inputV", inputV);

        float moveX = inputH * 60f ;
        float moveZ = inputV * 150f;

        rb.AddForce(new Vector3(moveX, 0f, moveZ));

    }
}
