using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectplaybutton : MonoBehaviour
{

	private bool isplaybutton = false;
	public GameObject selectplaybtn;
	private int k = 0;
	private AudioSource[] audiosources = new AudioSource[100];
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
		//var selects = GameObject.FindGameObjectsWithTag("select");
		GameObject[] obj;
		obj = GameObject.FindGameObjectsWithTag("select");
		if (isplaybutton)
		{
			int l = 0;
			//GameObject obj = GameObject.FindGameObjectWithTag("select");
			//AudioSource source;
			//source = obj.GetComponent<AudioSource>();
			/*foreach (GameObject select in obj)
            {
				audiosources [l] = obj [l].GetComponent<AudioSource> ();
				audiosources [l].Stop ();
				k++;
				l++;
            }*/
			for(int o = 0; o<k; l++){
				audiosources [o].Stop ();
			}
			isplaybutton = false;
			selectplaybtn.GetComponentInChildren<Text>().text = "play";
		}
		else
		{
			int i = 0;
			//GameObject[] obj = GameObject.FindGameObjectWithTag("select");
			foreach (GameObject select in obj) {
				audiosources [i] = obj [i].GetComponent<AudioSource> ();
				audiosources [i].Stop ();
				k++;
				i++;
			}
			for(int j = 0; i<k; i++)
			{
				audiosources[j].Play();
			}
			isplaybutton = true;
			selectplaybtn.GetComponentInChildren<Text>().text = "stop";
		}
	}

}
