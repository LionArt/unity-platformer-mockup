using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour {

    // Use this for initialization

    public GameObject player;
    public GameObject text;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player" && player.GetComponent<Rigidbody>().position.y>2)
        {
            text.GetComponent<Text>().text = "Gratulacje!";
            text.SetActive(true);
            StartCoroutine(ResetTimer());
        }
    }

    IEnumerator ResetTimer()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("OneSceneToRuleThemAll");
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
