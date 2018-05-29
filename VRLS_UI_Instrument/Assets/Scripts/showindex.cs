using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class showindex : MonoBehaviour {

	public GameObject showindexbtn;
	private bool buttonclick = false;
	public GameObject playbutton;
	public GameObject stopbutton;

	public GameObject panel;


	public void showPanel()
	{
		if (buttonclick)
		{
			playbutton.SetActive(false);
			stopbutton.SetActive (false);
			buttonclick = false;
			panel.SetActive(false);
			showindexbtn.GetComponentInChildren<Text>().text = "showindex";
		}
		else
		{
			playbutton.SetActive(true);
			stopbutton.SetActive (true);
			buttonclick = true;
			panel.SetActive(true);
			showindexbtn.GetComponentInChildren<Text>().text = "hideindex";
		}

	}

}
