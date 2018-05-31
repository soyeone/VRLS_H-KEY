using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoD : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().Play();
        GetComponent<Animator>().SetBool("down", true);
    }

    public void OnTriggerExit()  
    {
        GetComponent<Animator>().SetBool("down", false);
       
    }
}
