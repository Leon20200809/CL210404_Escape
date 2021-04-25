using UnityEngine;
using UniRx;
using UnityEngine.UI;



public class ReactiveButton : MonoBehaviour
{
    [SerializeField] private Button _button;



    // Start is called before the first frame update
    void Start()
    {
        _button.OnClickAsObservable().Subscribe(_ =>
        {
            Debug.Log("button clicked at " + Time.realtimeSinceStartup);
        }).AddTo(this);

    }
}