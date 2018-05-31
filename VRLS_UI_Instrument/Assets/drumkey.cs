using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drumkey : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   /* private void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();

    }*/


    private void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().Play();
        Renderer renderer = gameObject.GetComponent<Renderer>();
        renderer.material.color = Color.red;
    }

    private void OnTriggerExit()
    {
        Renderer renderer = gameObject.GetComponent<Renderer>();
        renderer.material.color = Color.white;
    }
}
