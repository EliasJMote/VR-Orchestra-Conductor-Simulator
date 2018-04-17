using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metronome : MonoBehaviour {
    public float bpm;
    public float offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.LookAt(target);
        //120 beats X 1 minute     X t seconds X 2(to account for sin wave)
        //    -----     ------
        //    minute  2*30 seconds 
        float z = offset + Mathf.Sin((float)AudioSettings.dspTime * bpm / 30);
        this.transform.localEulerAngles = new Vector3(
            0,     // rotation (degrees) about x-axis
            0,     // rotation (degrees) about y-axis
            z * 15 // rotation (degrees) about z-axis
            );
            
	}
}
