using DG.Tweening;
using System;
using UnityEngine;

public class zengo5 : MonoBehaviour
{
    void Start()
    {
        this.transform.DOMove(new Vector3(0, 0, 5f), 3f)
       .SetRelative(true)
       .SetLoops(-1, LoopType.Yoyo);
    }

}