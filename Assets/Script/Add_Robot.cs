using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// TODO: 名前修正 RobotFactory がいいかな（Add だとメソッド名っぽい）
public class Add_Robot : MonoBehaviour
{
    int RobotNum = 0;
    int RobotCost = 10;

    [SerializeField]
    GameObject Robot;

    [SerializeField]
    GameObject canvas;

    [SerializeField]
    Counter counter;
    
    Vector3 RobotPos;

    public void AddRobot()
    {
        if (counter.GainCount(RobotCost))
        {
            RobotPos = new Vector3(400, 380 - (70 * RobotNum), 0);
            Instantiate(Robot, RobotPos, Quaternion.identity);
            RobotNum++;
        }
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = RobotNum.ToString("Robot" + "   " + "0");
    }
}

