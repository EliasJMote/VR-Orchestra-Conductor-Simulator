using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class Volume : MonoBehaviour {
    public Text volumeText;
    public Text beatText;
    public Text goalVolume;
    public Text goalBeat;
    public Text totalScore;
    public Text crowdRating;
    // Use this for initialization
    private int volumeLvl;
    private int beat;
    private int total;
    private int crowd;

	void Start () {
        volumeLvl = 0;
        beat = 0;
        total = 0;
        crowd = 0;
        volumeText.text = "0";
        beatText.text = "0";
        goalBeat.text = "Beat: 120"; // read in these values
        goalVolume.text = "Volume: 70";  // read in these values
        totalScore.text = "0";
        Update();
		
	}
	public void AddVolScore()
    {
        volumeLvl = volumeLvl + 1;
        Update();
    }
    public void SubtractVolScore()
    {
        volumeLvl = volumeLvl - 1;
        Update();
    }
    public void AddBeatScore()
    {
        beat = beat + 1;
        Update();
    }
    public void SubtractBeatScore()
    {
        beat = beat - 1;
        Update();
    }
    public void AddTotal()
    {
        total += 1;
        Update();
    }
    public void SubTotal()
    {
        total -= 1;
        Update();
    }
    public void AddCrowd()
    {
        crowd += 1;
        Update();
    }
    public void SubCrowd()
    {
        crowd -= 1;
        Update();
    }
	// Update is called once per frame
	void Update () {
        volumeText.text = volumeLvl.ToString();
        beatText.text = beat.ToString();
    }
}
