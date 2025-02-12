using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    
    private void Start()
    {
        transform.DOMove(_position, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
