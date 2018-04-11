using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    Rigidbody rb;
    float speed = 10.0F;
    float height = 12.0F;
    bool canJump = false;
    public bool canPushTheButton=false;
    public bool isButtonPressed=false;
    public GameObject button;
    public List<GameObject> platforms;
    public Material green;
	// Use this for initialization
	void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float moveVertical = Input.GetAxis("Vertical")*speed;
        float moveHorizontal = Input.GetAxis("Horizontal")*speed;
        moveVertical *= Time.deltaTime;
        moveHorizontal *= Time.deltaTime;

        transform.Translate(moveHorizontal, 0, moveVertical);
       
        if(Input.GetKeyDown("space") && canJump)
        {
            rb.AddForce(Vector3.up * height, ForceMode.Impulse);
        }

        canJump = false;

        if (Input.GetKeyDown("escape"))
            Cursor.lockState=CursorLockMode.None;

        if(Input.GetKeyDown("e") && canPushTheButton && !isButtonPressed)
        {
            foreach(var item in platforms)
            {
                item.SetActive(true);
            }

            button.GetComponent<MeshRenderer>().material = green;
            isButtonPressed = true;
        }
            
	}

    void OnCollisionStay()
    {
        canJump = true;
    }
}
