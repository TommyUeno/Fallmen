using DG.Tweening;
using System;
using UnityEngine;
public class Rjouge10: MonoBehaviour
{
    void Start()
    {
        this.transform.DOLocalMove(new Vector3(0, 10f, 0), 3f)
       .SetRelative(true)
       .SetLoops(-1, LoopType.Yoyo);
    }

}