using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Gotomain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadSceneAsync("Main");
        }
    }

    public void OnClick()
    {
        Invoke("ChangeScene", 2f);
        SceneManager.LoadSceneAsync(3);
    }
}
