using UnityEngine;
using DG.Tweening;

public class Rotater : MonoBehaviour
{
    [SerializeField] private Vector3 _degree;
    [SerializeField] private float _duration;
    
    private void Start()
    {
        transform.DOLocalRotate(_degree, _duration).SetLoops(-1, LoopType.Incremental);
    }
}
