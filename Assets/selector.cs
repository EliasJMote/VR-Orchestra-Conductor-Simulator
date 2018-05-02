using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selector : MonoBehaviour {
    public int selectorIndex = 5;
    public int instSelection = 5;
    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update(){}

    private Transform SelectorTransform()
    {
        Transform parentTransform = this.transform.GetChild(selectorIndex);
        return parentTransform.GetChild(0);
    }

    private Transform InstrumentTransform(int k)
    {
        return this.transform.GetChild(k);
    }

    public void MoveSelector(int k)
    {
        SelectorTransform().SetParent(InstrumentTransform(k), false);
        selectorIndex = k;
    }

}
