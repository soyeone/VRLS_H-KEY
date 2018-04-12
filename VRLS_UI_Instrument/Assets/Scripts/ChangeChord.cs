using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeChord : MonoBehaviour
{
    public GameObject playone;
    public GameObject stopone;
    public GameObject stopone2;
    public GameObject stopone3;
    public GameObject stopone4;

    public void Change_Chord() {

        playone.SetActive(true);
        stopone.SetActive(false);
        stopone2.SetActive(false);
        stopone3.SetActive(false);
        stopone4.SetActive(false);

    }
}
