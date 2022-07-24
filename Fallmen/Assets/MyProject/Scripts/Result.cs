using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Result : MonoBehaviour
{
    private GameObject ScoreMaster;
    private ScoreData Sd;
    public TextMeshProUGUI tex;
    int Score;

    void Start()
    {
        ScoreMaster = GameObject.Find("ScoreData");  //ScoreDataを見つける
        Sd = ScoreMaster.GetComponent<ScoreData>();

        Score = Sd.GetScore();  //ScoreDataの中のGetScore関数を呼び出す
        //アタッチしたオブジェクトに反映したいテキストを紐づける。
        tex.text = string.Format("Score  {0}", Score);
    }
}