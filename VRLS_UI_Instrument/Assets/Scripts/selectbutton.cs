using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectbutton : MonoBehaviour {

    private bool isplay = false;
    public GameObject audiosource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void selectsource()
    {
        //AudioSource source;
        //source = audiosource.GetComponent<AudioSource>();
        if (isplay)
        {
            transform.gameObject.tag = "Untagged";
            isplay = false;
            audiosource.GetComponentInChildren<Text>().text = "Record";
        }
        else
        {
            transform.gameObject.tag = "select";
            //source.Play();
            isplay = true;
            audiosource.GetComponentInChildren<Text>().text = "Record(select)";
        }
    }
}
