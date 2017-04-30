using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCameraController : MonoBehaviour {

    public GameObject player;
    public GameObject ball;

    private Vector3 offset;
    private int frame;

    // Use this for initialization
    void Start () {
        transform.position = new Vector3(0, 15, -15);
        offset = transform.position - player.transform.position;
        frame = 0;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        frame++;
        print(frame);
        Vector3 move = new Vector3(0, -2, 1);
        Vector3 move2 = new Vector3(-1, 0, 0);

        if (frame <= 150)
        {
            
            transform.Translate(move * Time.deltaTime);
        }
        else if(frame <= 450)
        {
            if(frame == 151)
            {
                transform.position = player.transform.position + new Vector3(0, 5, -5);


                //transform.Translate(move2 * Time.deltaTime);
            }
            transform.LookAt(player.transform);
            transform.Translate(Vector3.left * Time.deltaTime);
            //transform.Rotate(new Vector3(0, 20, 0) * Time.deltaTime);

        }
        else
        {
            transform.LookAt(ball.transform);
            transform.Translate(Vector3.left * Time.deltaTime);
        }

    }
}
