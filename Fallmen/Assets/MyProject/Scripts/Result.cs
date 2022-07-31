using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Result : MonoBehaviour
{
    private GameObject ScoreMaster;
    private ScoreData Sd;
    public TextMeshProUGUI tx;
    int second;
    int minute;
    int hour;

    void Start()
    {
        ScoreMaster = GameObject.Find("ScoreData");  //ScoreDataを見つける
        Sd = ScoreMaster.GetComponent<ScoreData>();

       int second = (int)Sd.GetScore();  //ScoreDataの中のGetScore関数を呼び出す
       float minute = Sd.GetScore();
       float hour = Sd.GetScore();

        //アタッチしたオブジェクトに反映したいテキストを紐づける。
        //tx.text = string.Format("Score  {0:00:00:00}", second,minute,hour);

        tx.text = hour.ToString() + ":" + minute.ToString("00") + ":" + second.ToString("f2");

    }
}