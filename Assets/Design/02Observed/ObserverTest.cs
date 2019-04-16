using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Design.Observer2;

public class ObserverTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Test();
    }
    WeatherData data;
    DisplayDevice2 display2;
    void Test()
    {
        data = new WeatherData();
        DisplayDevice1 display1 = new DisplayDevice1(data);
        display2 = new DisplayDevice2(data);
        data.SetData(70, 80, 90);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            //设备2从观察者中移除，不想在收到WeatherData发送的数据
            display2.UnRegist();
            data.SetData(10, 10, 10);
        }
    }
}
