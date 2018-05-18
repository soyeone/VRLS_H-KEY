using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectplaybutton : MonoBehaviour
{

	private bool isplaybutton = false;
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
		obj = GameObject.FindGameObjectsWithTag("select");

        int i = 0;

        foreach (GameObject select in obj)
        {
            audiosources[i] = obj[i].GetComponent<AudioSource>();
            audiosources[i].Stop();
            k++;
            i++;
        }

        if (isplaybutton)
		{
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

			for(int o = 0; o<k; o++){
				audiosources [o].Stop ();
			}
			isplaybutton = false;
			selectplaybtn.GetComponentInChildren<Text>().text = "play";
		}
		else
		{
			for(int j = 0; j<k; j++)
			{
				audiosources[j].Play();
			}
			isplaybutton = true;
			selectplaybtn.GetComponentInChildren<Text>().text = "stop";
		}
	}

}
