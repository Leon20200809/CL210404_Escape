using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class Presenter : MonoBehaviour
{
    public IntReactiveProperty resultValue = new IntReactiveProperty();
    [SerializeField] private Slider source_slider;
    [SerializeField] private UniRx_Int source_IntRP;
    private Slider currentSource;
    private bool isSource1 = true;

    // Start is called before the first frame update
    void Start()
    {
        //source_slider.OnValueChangedAsObservable().Subscribe(v =>
        //{
        //    resultValue.Value = (int)v;
        //}).AddTo(this);


        source_IntRP.testRxInt.Subscribe(i =>
        {
            int v;
            if (i > 1000)
            {
                //1000より大きくなったら1000にする、上限を設定
                v = 1000;
            }
            else
            {
                v = i;
            }
            resultValue.Value = v;
        }).AddTo(this);
    }
}