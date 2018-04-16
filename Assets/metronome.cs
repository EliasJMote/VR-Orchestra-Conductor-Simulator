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
        float z = offset + Mathf.Sin((float)AudioSettings.dspTime * bpm / 30);
        this.transform.localEulerAngles = new Vector3(0, 0, z * 15);
            
	}
}
