using DG.Tweening;
using System;
using UnityEngine;
public class yoko30 : MonoBehaviour
{
    void Start()
    {
        this.transform.DOMove(new Vector3(60f, 0, 0), 6f)
       .SetRelative(true)
       .SetLoops(-1, LoopType.Yoyo);
    }

}
