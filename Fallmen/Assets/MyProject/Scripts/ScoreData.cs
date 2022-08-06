using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreData : MonoBehaviour
{
    public int minute,hour;
    public float second;
 

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);  //DontDestroyOnLoadでシーン遷移後も保存出来る
        second = 00;  //ゲームスタート時のスコア
        minute = 00;
        hour = 00;
        
    }

    public float GetScore()
    {
        return second;  //スコア変数をResultスクリプトへ返す
      
    }
    public int getminutes()
    {
        return minute;
    }
    public int gethour()
    {
        return hour;
    }

}