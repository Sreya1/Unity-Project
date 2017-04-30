using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

    private bool fly;

    void Start()
    {
        fly = false;
    }

    // Update is called once per frame before 
    void Update () {
        if (Input.GetKeyDown(KeyCode.B))
        {
            print("Hi");
            fly = true;
        }
        if (fly)
        {
            transform.Translate(new Vector3(0, 10, -10) * Time.deltaTime);
        }
    }
}