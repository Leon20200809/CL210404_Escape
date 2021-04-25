using UnityEngine;
using UniRx;
using UnityEngine.UI;
public class PresenterToText : MonoBehaviour
{
    [SerializeField] private Presenter _presenter;
    [SerializeField] private Text _text;
    void Start()
    {
        _presenter.resultValue.Subscribe(x =>
        {
            _text.text = x + "Point ";
            if (x < 400)
            {
                _text.color = Color.red;
            }
            else
            {
                _text.color = Color.green;
            }
        }).AddTo(this);
    }
}