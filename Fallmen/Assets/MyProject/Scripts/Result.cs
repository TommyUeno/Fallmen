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
    float second;
    int minute;
    int hour;

   public void Start()
    {
        ScoreMaster = GameObject.Find("ScoreData");  //ScoreDataを見つける
        Sd = ScoreMaster.GetComponent<ScoreData>();

        second = Sd.GetScore();  //ScoreDataの中のGetScore関数を呼び出す
        minute = Sd.GetScore();
        hour = Sd.GetScore();

        //アタッチしたオブジェクトに反映したいテキストを紐づける。
        tx.text = string.Format("Score  {0:00:00:00}", hour,minute,second);
        
       // tx.text = string.Format(hour.ToString() + ":" + minute.ToString("00") + ":" + second.ToString("f2"));
    }
}