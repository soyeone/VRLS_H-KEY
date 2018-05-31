using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class kickdrumsound : MonoBehaviour {

    SteamVR_Controller.Device _leftDevice;

    SteamVR_Controller.Device _rightDevice;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        

        if (_rightDevice != null && _rightDevice.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            GetComponent<AudioSource>().Play();
        
	}

    
    
}
