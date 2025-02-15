using UnityEngine;
using DG.Tweening;

public class ColorChanger : DoBase
{
    [SerializeField] private Color _color;
    
    private Material _material;
    
    private void Start()
    {
        _material = GetComponent<MeshRenderer>().material;
        
        _material.DOColor(_color, Duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
