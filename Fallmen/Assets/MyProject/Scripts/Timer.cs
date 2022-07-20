using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI timerText;
    private float second;
    private int minute;
    private int hour;
    private object collision;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        second += Time.deltaTime;

        if (minute >= 60)
        {
            hour++;
            minute = 0;
        }
        if (second > 60f)
        {
            minute++;
            second = 0;
        }

        timerText.text = hour.ToString() + ":" + minute.ToString("00") + ":" + second.ToString("f2");

    }
}
