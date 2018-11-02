using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: 名前、_ いらない
public class Rate_Controller : MonoBehaviour {

    [SerializeField]
    GameObject counterObj;

    Counter counter;

    int Time = 0;
    int AttackRate = 180;
    int UpRateCost = 30;

    public void UpRate()
    {
        if (counter.GainCount(UpRateCost))
        {

        }
    }

    public bool AttackOrder()
    {
        if (Time % AttackRate==0) {
            return true;
        }
        return false;
    }

	// Use this for initialization
	void Start () {
        counter = counterObj.GetComponent<Counter>();
    }
	
	// Update is called once per frame
	void Update () {
        Time++;
	}
}
