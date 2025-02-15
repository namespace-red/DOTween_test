using UnityEngine;
using DG.Tweening;

public class Rotater : DoBase
{
    [SerializeField] private Vector3 _degree;
    
    private void Start()
    {
        transform.DOLocalRotate(_degree, Duration).SetLoops(-1, LoopType.Incremental);
    }
}
