using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GotoTFP : MonoBehaviour
{
    [SerializeField] OVRScreenFade OVRFade;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("ChangeScene", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ChangeScene()
    {
        OVRFade.FadeOut();
        SceneManager.LoadSceneAsync("ThanksForPlaing");
    }
}