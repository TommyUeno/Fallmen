using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReGotoRobie : MonoBehaviour
{
    [SerializeField] OVRScreenFade OVRFade;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("ChangeScene", 17f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScene()
    {
        OVRFade.FadeOut();
        SceneManager.LoadSceneAsync("Robie");
    }
}
