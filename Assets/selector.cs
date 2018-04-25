using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selector : MonoBehaviour {
    int selectorIndex = 5;
    // Use this for initialization
    void Start () {


        
      

    }

    // Update is called once per frame
    void Update () {
	    if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            MoveSelector(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MoveSelector(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            MoveSelector(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            MoveSelector(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            MoveSelector(4);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MoveSelector(5);
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

}
