using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour {

    [SerializeField]
    GameObject Lazer;

    [SerializeField]
    GameObject canvas;

    Vector3 vector3 = new Vector3(78, 206, 0);

    /// ボタンをクリックした時の処理
    public void OnClick()
    {  
        Instantiate(Lazer, vector3, Quaternion.identity);
    }

}
