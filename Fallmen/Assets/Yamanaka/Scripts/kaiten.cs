using DG.Tweening;
using System;
using UnityEngine;

public class kaiten : MonoBehaviour
{
    void Start()
    {
        this.transform.DORotate(new Vector3(0, 0, 90f) ,12f)
       .SetRelative(true)
       .SetLoops(-1, LoopType.Yoyo);
    }

}