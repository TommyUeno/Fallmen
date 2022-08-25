using DG.Tweening;
using System;
using UnityEngine;

public class zengo50 : MonoBehaviour
{
    void Start()
    {
        this.transform.DOMove(new Vector3(0, 0, 50f), 7f)
       .SetRelative(true)
       .SetLoops(-1, LoopType.Yoyo);
    }

}