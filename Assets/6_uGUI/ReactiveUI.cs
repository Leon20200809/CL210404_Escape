using System;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class ReactiveUI : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Slider _slider;
    [SerializeField] private Text _text_slider;
    [SerializeField] private Toggle _toggle;
    [SerializeField] private Text _text_toggle;
    [SerializeField] private InputField _inputField;
    [SerializeField] private Text _text_inputfield;

    void Start()
    {
        _button.OnClickAsObservable().Subscribe(_ => { Debug.Log("button clicked at " + Time.realtimeSinceStartup); })
            .AddTo(this);

        _slider.OnValueChangedAsObservable().Subscribe(v =>
        {
            Debug.Log("value changed : " + v);
            _text_slider.text = v.ToString();
        }).AddTo(this);

        _inputField.OnValueChangedAsObservable().Subscribe(v =>
        {
            _text_inputfield.text = v;
        }).AddTo(this);

    }
}