using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    
    private void Start()
    {
        _text.DOText("Заменил", _duration);
        _text.DOText(", добавил", _duration).SetRelative().SetDelay(_duration);
        _text.DOText("Расшифрованный текст", _duration, true, ScrambleMode.All).SetDelay(_duration * 2);
    }
}
