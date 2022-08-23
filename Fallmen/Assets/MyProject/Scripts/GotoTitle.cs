using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GotoTitle : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Invoke("ChangeScene", 5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeScene()
    {
        SceneManager.LoadSceneAsync("Title");
    }
}