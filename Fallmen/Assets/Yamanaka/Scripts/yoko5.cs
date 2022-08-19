using DG.Tweening;
using System;
using UnityEngine;

public class yoko5 : MonoBehaviour
{
    void Start()
    {
        this.transform.DOMove(new Vector3(5f, 0, 0), 3f)
       .SetRelative(true)
       .SetLoops(-1, LoopType.Yoyo);
    }

}