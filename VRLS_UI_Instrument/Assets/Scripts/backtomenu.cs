using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backtomenu : MonoBehaviour {

    public GameObject piano;
    public GameObject drum;
    public GameObject guitar;
    public GameObject voice;
    public GameObject menu;
    public GameObject backk;



    public void tomenu() {

        piano.SetActive(false);
        drum.SetActive(false);
        guitar.SetActive(false);
        voice.SetActive(false);
        menu.SetActive(true);
        backk.SetActive(false);
    }
}
