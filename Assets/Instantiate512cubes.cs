using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate512cubes : MonoBehaviour {
    public GameObject _sampleCubePrefab;
    GameObject[] _sampleCube = new GameObject[30];
    public float _maxScale;
    public audiopeer _audio;
    public int bands;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < bands; i++)
        {
            GameObject _instanceSampleCube = (GameObject)Instantiate(_sampleCubePrefab);
            //_instanceSampleCube.transform.position = this.transform.position;
            _instanceSampleCube.transform.parent = this.transform;
            _instanceSampleCube.name = "SampleCube" + i;
            //this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            float offset = this.transform.localScale.x / 2;
            float shift = this.transform.localScale.x / bands;
            float x = (i - bands / 2) * shift;
            float y = this.transform.localScale.y / 2;
            _instanceSampleCube.transform.localPosition = new Vector3(x, y , 0);
            _sampleCube[i] = _instanceSampleCube;
        }
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < bands; i++)
        {
            if(_sampleCube != null)
            {
                _sampleCube[i].transform.localScale = new Vector3(10, (_audio._samples[i] * _maxScale) + 2, 10);
            }
        }
	}
}
