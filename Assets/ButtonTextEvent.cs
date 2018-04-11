using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class ButtonTextEvent : MonoBehaviour {

    public GameObject text;
    CharacterController scriptRef;
    GameObject objectRef;

    void Start()
    {
        objectRef = GameObject.FindGameObjectWithTag("Player");
        scriptRef = objectRef.GetComponent<CharacterController>();
    }
    // Use this for initialization
    void OnTriggerEnter()
    {
        if (scriptRef.isButtonPressed==false)
        {
            text.GetComponent<Text>().text = "Wciśnij \"E\" aby uruchomić.";
            text.SetActive(true);
            scriptRef.canPushTheButton=true;
        }

    }

    void OnTriggerExit()
    {
        text.SetActive(false);
    }
    // Update is called once per frame
    void Update() {

    }

    void ChangeText()
    {

    }
}
