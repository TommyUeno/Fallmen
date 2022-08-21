using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mp4Manager : MonoBehaviour
{
    [SerializeField] GameObject mp4;
    [SerializeField] float delaySpeed;

    // Start is called before the first frame update
    void Start()
    {
        mp4.SetActive(true);
        Invoke(nameof(DelayMethod), delaySpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DelayMethod()
    {
        mp4.SetActive(false);
    }
}
