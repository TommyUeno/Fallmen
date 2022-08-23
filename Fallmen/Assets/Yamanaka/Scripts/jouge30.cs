using DG.Tweening;
using System;
using UnityEngine;

public class jouge30 : MonoBehaviour
{
    void Start()
    {
        this.transform.DOMove(new Vector3(0, 30f, 0), 6f)
       .SetRelative(true)
       .SetLoops(-1, LoopType.Yoyo);
    }

}