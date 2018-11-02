using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerMove : MonoBehaviour {

    int speed=7;
    int Attack = 1;

    GameObject obj;

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Counter counter = obj.GetComponent<Counter>();
            counter.AddCount(Attack);
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        obj = GameObject.Find("Count");
	}
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.transform.position.y > 0)
        {
            this.gameObject.transform.Translate(speed, 0, 0);
        }
	}
}
