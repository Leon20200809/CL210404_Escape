using UnityEngine;
using UniRx;
using UnityEngine.UI;
public class TestReactiveIntToText : MonoBehaviour
{
    [SerializeField] private UniRx_Int _rxInt;
    private Text _text;
    void Start()
    {
        _text = GetComponent<Text>();
        
        _rxInt.testRxInt.Subscribe(x =>
        {
            _text.text = x + "Point ";
            if (x > 1000)
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