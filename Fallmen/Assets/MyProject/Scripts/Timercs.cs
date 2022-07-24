using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timercs : MonoBehaviour
{
    private TextMeshProUGUI timerText;
    private float second;
    private int minute;
    private int hour;
    private object collision;

    //???????
    public int Score;
    public ScoreData Sd;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();

        Score = 0;
        Sd = GameObject.Find("ScoreData").GetComponent<ScoreData>();//???????????


    }

    // Update is called once per frame
    void FixedUpdate()
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

    public void TimerStop()
    {
        Time.timeScale = Mathf.Approximately(Time.timeScale, 0f) ? 1f : 0f;

    }


    void Update()
    {
        timerText.text = string.Format("{0}", Score);  //GameMain??????????
        Sd.Score = Score;  //ScoreData???Score
    }
}

