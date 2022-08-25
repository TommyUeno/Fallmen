using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReGotoRobie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ChangeScene", 14f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ChangeScene()
    {
        SceneManager.LoadSceneAsync("Robie");
    }
}
