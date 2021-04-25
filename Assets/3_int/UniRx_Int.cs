using UnityEngine;
using UniRx;

public class UniRx_Int : MonoBehaviour
{
    public IntReactiveProperty testRxInt { get; private set; } = new IntReactiveProperty(0);


    void Update()
    {
        testRxInt.Value = (int) (Time.realtimeSinceStartup * 100);
        Debug.Log(testRxInt.Value);
    }
}