using DG.Tweening;
using System;
using UnityEngine;

public class jouge90 : MonoBehaviour
{
    void Start()
    {
        this.transform.DOMove(new Vector3(0, 90f, 0), 6f)
       .SetRelative(true)
       .SetLoops(-1, LoopType.Yoyo);
    }

}