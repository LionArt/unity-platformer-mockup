using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour {

    // Use this for initialization
    float sensitivityV = 5.0f;
    float sensitivityH = 3.0f;
    float rotationX = 0;
    Rigidbody rb;

    GameObject character;
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        rb.transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityH, 0);
        rotationX -= Input.GetAxis("Mouse Y") * sensitivityV;
        rotationX = Mathf.Clamp(rotationX, -45.0f, 45.0f);
        rb.transform.localEulerAngles = new Vector3(rotationX, rb.transform.localEulerAngles.y, 0);
    }
}
