using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selector : MonoBehaviour {
    public int selectorIndex = 5;
    public int instSelection = 5;
    //public Vector2 stickInput;
    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        OVRInput.Update();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            MoveSelector(0);
            instSelection = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MoveSelector(1);
            instSelection = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            MoveSelector(2);
            instSelection = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            MoveSelector(3);
            instSelection = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            MoveSelector(4);
            instSelection = 4;
        }
        if (Input.GetKeyDown(KeyCode.Escape) )
        {
            MoveSelector(5);
            instSelection = 5;
        }
        //Debug.Log(OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick));
        if (OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x > 0)
        {
            instSelection++;
            if (instSelection > 5)
                instSelection = 0;
            MoveSelector(instSelection);
        }
        else if (OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x < 0)
        {
            instSelection--;
            if (instSelection < 0)
                instSelection = 5;
            MoveSelector(instSelection);
        }
    }

    private Transform SelectorTransform()
    {
        Transform parentTransform = this.transform.GetChild(selectorIndex);
        return parentTransform.GetChild(0);
    }

    private Transform InstrumentTransform(int k)
    {
        return this.transform.GetChild(k);
    }

    private void MoveSelector(int k)
    {
        SelectorTransform().SetParent(InstrumentTransform(k), false);
        selectorIndex = k;
    }

    void FixedUpdate()
    {
        OVRInput.FixedUpdate();
    }

}
