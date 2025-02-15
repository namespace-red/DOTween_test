using UnityEngine;
using DG.Tweening;

public class Scaler : DoBase
{
    [SerializeField] private Vector3 _scale;
    
    private void Start()
    {
        transform.DOScale(_scale, Duration).SetLoops(-1, LoopType.Yoyo);
    }
}
