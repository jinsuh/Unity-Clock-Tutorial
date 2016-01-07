using UnityEngine;
using System;

public class ClockScript : MonoBehaviour {

    public GameObject HourHand, MinuteHand, SecondHand;
    	// Use this for initialization
    private void RotateByFraction(GameObject obj, float fraction)
    {
        Transform transform = obj.GetComponent<Transform>();
        transform.localRotation = Quaternion.Euler(0, 0, fraction * 360);
    }
	
	// Update is called once per frame
	void Update () {
        RotateByFraction(HourHand, DateTime.Now.Hour / 12f);
        RotateByFraction(MinuteHand, DateTime.Now.Minute / 60f);
        RotateByFraction(SecondHand, DateTime.Now.Second / 60f);
    }
}
