using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Counter : MonoBehaviour {

    private float count = 0;

    public void AddCount(int a)
    {
        count += a;
    }
    
    public bool GainCount(int gainValue)
    {
        if(count >= gainValue)
        {
            count -= gainValue;
            return true;
        }

        return false;
    }

    // Use this for initialization
    void Start () {
        count = 0;
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = count.ToString("F0");
    }
}
