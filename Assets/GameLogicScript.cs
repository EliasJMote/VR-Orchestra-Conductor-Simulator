using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogicScript : MonoBehaviour
{
    public Instantiate512cubes volviz;

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
    //private int currentSliderNum;

    // Game timer
    public int timer;

    // Use this for initialization
    void Start()
    {
        timer = 0;
        //currentSliderNum = 0;

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
    void Update()
    {
        OVRInput.Update();
        Vector3 RTouchVel = OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch);
        Debug.Log(RTouchVel);
        //Debug.Log(volviz.volscale);
        timer++;
		if(timer % 10 == 0){
			//if(timer > 30 * 3)
				//WoodwindSlider.value--;
			//if(timer > 30 * 6)
				//StringSlider.value--;
			/*if(timer > 30 * 9)
				HornSlider.value++;
			if(timer > 30 * 12)
				PercussionSlider.value++;*/
		}
        if (timer % 60 * 10 == 0)
        {
           // volviz.volscale = 10f;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            volviz.volscale -= 1f;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            volviz.volscale += 1f;
        }
        if ((RTouchVel.y > 1 && volviz.volscale < 5f) || (RTouchVel.y < -1 && volviz.volscale > 5f))
        {
            volviz.volscale = 5f;
        }
            /*if (Input.GetKeyDown("z") || OVRInput.Get(OVRInput.Button.One))
            {
                StringSlider.value = 100;
            }*/

        if (OVRInput.Get(OVRInput.Button.One))
        {
            UnityEngine.XR.InputTracking.Recenter();
        }
    }

    void FixedUpdate()
    {
        OVRInput.FixedUpdate();
    }
}

