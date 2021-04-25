using UnityEngine;
using UniRx;
public class UniRx_Bool : MonoBehaviour
{
    public BoolReactiveProperty testRxBool = new BoolReactiveProperty(false);
        
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            testRxBool.Value = !testRxBool.Value;
        }
        
    }
}
