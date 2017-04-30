using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLightController : MonoBehaviour {

    public GameObject focusPoint;
    private Vector3 offset;

    // Use this for initialization
    void Start () {
        offset = new Vector3(0, 6, 0);
        transform.position = focusPoint.transform.position + offset ;
    }

    // Update is called once per frame
    void Update () {
        transform.position = focusPoint.transform.position + offset;		
	}
}
