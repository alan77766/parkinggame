using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject Car;
    GameObject Flag;
    GameObject Distance;
    GameObject Score;

    // Start is called before the first frame update
    void Start()
    {
        Car = GameObject.Find("car");
        Flag = GameObject.Find("flag");
        Distance = GameObject.Find("Distance");
        Score = GameObject.Find("score");
    }

    // Update is called once per frame
    void Update()
    {
        float Length = Flag.transform.position.x - Car.transform.position.x;
        Distance.GetComponent<Text>().text = "距離目標還有：" + Length.ToString("F2") + "公尺";
        float Figure = 100 / Length;
        Score.GetComponent<Text>().text = "分數:" + Figure.ToString(); 



    }
}
