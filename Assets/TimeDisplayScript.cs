using UnityEngine;
using System;
using UnityEngine.UI;

public class TimeDisplayScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        string currentTime = DateTime.Now.ToShortTimeString();
        this.GetComponent<Text>().text = currentTime;
	}
}
