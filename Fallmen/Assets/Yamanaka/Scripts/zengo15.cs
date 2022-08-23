using DG.Tweening;
using System;
using UnityEngine;


public class zengo15 : MonoBehaviour
{
    void Start()
    {
        this.transform.DOMove(new Vector3(0, 0, 15f), 6f)
       .SetRelative(true)
       .SetLoops(-1, LoopType.Yoyo);
    }

}