using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestGameTime :Game {
    public Text timeText;
    public int time_int;
    // Use this for initialization
    void Start () {
        InvokeRepeating("Timer", 1, 1);
        timeText = GetComponent<Text>();
    }

    void Timer()
    {
        time_int--;
        timeText.text = ""+time_int ;

        if (time_int == 0)
        {
            CancelInvoke("timer");
        }
    }
}
