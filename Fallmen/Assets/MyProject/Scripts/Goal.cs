using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public Timercs timer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Player"))
        {
           // timer.TimerStop();

            Debug.Log(" scene cange");

            SceneManager.LoadScene("End");
        }
    }
}
