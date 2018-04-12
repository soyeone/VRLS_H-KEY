using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ob_onoff : MonoBehaviour {

    public GameObject ob;

    public GameObject button_all;
    public GameObject backk;

    // Use this for initialization
    public void onoff() {

        ob.SetActive(true);
        button_all.SetActive(false);
        backk.SetActive(true);
               

    }
}
