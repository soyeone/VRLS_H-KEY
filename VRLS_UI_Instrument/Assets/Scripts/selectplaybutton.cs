using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectplaybutton : MonoBehaviour
{
	public GameObject selectplaybtn;
	private AudioSource[] audiosources = new AudioSource[100]; // 임의로 100개만;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void selectplay()
	{
		int k = 0;

		GameObject[] obj;
		obj = GameObject.FindGameObjectsWithTag ("select");

		int i = 0;

		foreach (GameObject select in obj) {
			audiosources [i] = obj [i].GetComponent<AudioSource> ();
			audiosources [i].Stop ();
			k++;
			i++;
		}

		for (int o = 0; o < k; o++) {
			audiosources [o].Play ();
		}
	}


	public void selectstop()
	{

		GameObject[] obj;
		obj = GameObject.FindGameObjectsWithTag ("select");

		int i = 0;

		foreach (GameObject select in obj) {
			audiosources [i] = obj [i].GetComponent<AudioSource> ();
			audiosources [i].Stop ();
			i++;
		}
	}
}
