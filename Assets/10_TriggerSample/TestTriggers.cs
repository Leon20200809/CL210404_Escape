using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class TestTriggers : MonoBehaviour
{
    void Start()
    {
        this.OnCollisionEnterAsObservable()
            .Where(x => x.gameObject.CompareTag("Player"))
            .Subscribe(_ =>
                GetComponent<Renderer>().material.color = Color.red
            );
    }
}