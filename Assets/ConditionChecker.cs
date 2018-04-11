using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConditionChecker : MonoBehaviour {

    // Use this for initialization
    public Rigidbody rb;
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (rb.position.y < -5)
        SceneManager.LoadScene("OneSceneToRuleThemAll");
    }
}
