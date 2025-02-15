using UnityEngine;
using DG.Tweening;

public class Mover : DoBase
{
    [SerializeField] private Vector3 _position;
    
    private void Start()
    {
        transform.DOMove(_position, Duration).SetLoops(-1, LoopType.Yoyo);
    }
}
