using UnityEngine;
using UniRx;
public class TesterReactiveBool : MonoBehaviour
{
    [SerializeField] private UniRx_Bool _rxBool;
    void Start()
    {
        Renderer re = GetComponent<Renderer>();

        _rxBool.testRxBool.Subscribe(x =>
        {
            if (x)
            {
                re.material.color = Color.red;
            }
            else
            {
                re.material.color = Color.green;
            }
        }).AddTo(this);
    }
}