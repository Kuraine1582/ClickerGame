using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotControl : MonoBehaviour {

    [SerializeField]
    GameObject Robot;

    [SerializeField]
    GameObject Bullet;

    [SerializeField]
    GameObject canvas;

    [SerializeField]
    GameObject counterObj; // TODO: GameObject の必要ない。最初から Counter で

    [SerializeField]
    GameObject RateControler; // TODO: ↑と同じ

    Counter counter;
    Rate_Controller Rate_Controller;
    
    int UpRateCost = 30;

    // Use this for initialization
    void Start () {
        counter = counterObj.GetComponent<Counter>();
        Rate_Controller = RateControler.GetComponent<Rate_Controller>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Robot.transform.position.y > 0)
        {
            if (Rate_Controller.AttackOrder())
            {
                Vector3 RobotPos = Robot.transform.position;
                Vector3 BulletPos = new Vector3(RobotPos.x + 45, RobotPos.y, 0);

                Instantiate(Bullet, BulletPos, Quaternion.identity);
            }
        }
	}
}
