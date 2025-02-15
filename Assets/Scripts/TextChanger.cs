using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : DoBase
{
    [SerializeField] private Text _text;
    
    private void Start()
    {
        Sequence mySequence = DOTween.Sequence();

        mySequence.Append(_text.DOText("Заменил", Duration))
            .Append(_text.DOText(", добавил", Duration).SetRelative())
            .Append(_text.DOText("Расшифрованный текст", Duration, true, ScrambleMode.All))
            .SetLoops(-1, LoopType.Restart);
    }
}
