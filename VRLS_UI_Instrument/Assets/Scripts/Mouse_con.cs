using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_con : MonoBehaviour {

    public AudioClip o_sound;

    private void OnMouseEnter()
    {
        AudioSource.PlayClipAtPoint(o_sound, transform.position);

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
