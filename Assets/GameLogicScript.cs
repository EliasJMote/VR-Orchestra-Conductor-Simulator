using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogicScript : MonoBehaviour {

	// Music section UI sliders
	public Slider WoodwindSlider;
	public Slider StringSlider;
	public Slider HornSlider;
	public Slider PercussionSlider;

	// Music section UI text
	public Text woodwindText;
	public Text stringText;
	public Text hornText;
	public Text percussionText;

	// Indicates which slider we are on
	private int currentSliderNum;

	// Game timer
	public int timer;

	// Use this for initialization
	void Start () {
		timer = 0;
		currentSliderNum = 0;

		WoodwindSlider = WoodwindSlider.GetComponent<Slider>();
		StringSlider = StringSlider.GetComponent<Slider>();
		HornSlider = HornSlider.GetComponent<Slider>();
		PercussionSlider = PercussionSlider.GetComponent<Slider>();

		woodwindText = woodwindText.GetComponent<Text>();
		stringText = stringText.GetComponent<Text>();
		hornText = hornText.GetComponent<Text>();
		percussionText = percussionText.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		timer++;
		if(timer % 10 == 0){
			if(timer > 30 * 3)
				WoodwindSlider.value--;
			if(timer > 30 * 6)
				StringSlider.value--;
			if(timer > 30 * 9)
				HornSlider.value++;
			if(timer > 30 * 12)
				PercussionSlider.value++;
		}
		if (Input.GetKeyDown("z")){
			if(currentSliderNum == 0)
				WoodwindSlider.value = 50;
			else if(currentSliderNum == 1)
				StringSlider.value = 50;
			else if(currentSliderNum == 2)
				HornSlider.value = 50;
			else if(currentSliderNum == 3)
				PercussionSlider.value = 50;
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)){
			if(currentSliderNum < 3)
				currentSliderNum++;
			else
				currentSliderNum = 0;
		}
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			if(currentSliderNum > 0)
				currentSliderNum--;
			else
				currentSliderNum = 3;
		}
		Debug.Log(currentSliderNum);

		if(currentSliderNum == 0){
			woodwindText.color = Color.red;
			stringText.color = Color.white;
			hornText.color = Color.white;
			percussionText.color = Color.white;
		}
		else if(currentSliderNum == 1){
			woodwindText.color = Color.white;
			stringText.color = Color.red;
			hornText.color = Color.white;
			percussionText.color = Color.white;
		}
		else if(currentSliderNum == 2){
			woodwindText.color = Color.white;
			stringText.color = Color.white;
			hornText.color = Color.red;
			percussionText.color = Color.white;
		}
		else if(currentSliderNum == 3){
			woodwindText.color = Color.white;
			stringText.color = Color.white;
			hornText.color = Color.white;
			percussionText.color = Color.red;
		}
	}
}
