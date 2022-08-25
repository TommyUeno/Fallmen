using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Gotomain : MonoBehaviour
{
    [SerializeField] OVRScreenFade OVRFade;

    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadSceneAsync(3);
        }
    }
    public void ChangeScene()
    {
        

        SceneManager.LoadSceneAsync("Stage");
    }

    public void OnClick()
    {
        OVRFade.FadeOut();

        Invoke("ChangeScene", 3f);

      
        
    }
}
