using UnityEngine;
using UniRx;
public class TesterReactiveBoolRandom : MonoBehaviour
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
                re.material.color = new Color(
                    Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f)
                    );
            }
        }).AddTo(this);
    }
}
