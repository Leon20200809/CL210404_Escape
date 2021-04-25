using UnityEngine;
using UniRx;
public class HPBar_cube : MonoBehaviour
{
    [SerializeField] private UniRx_Int _rxInt;
    [SerializeField] private GameObject renderingTargetObj;
    void Start()
    {
        Renderer re = renderingTargetObj.GetComponent<Renderer>();
        _rxInt.testRxInt.Subscribe(x =>
        {
            // x = x >= 1000 ? 1000 : x;

            if (x >= 1000)
            {
                x = 1000;
            }
            
            Vector3 cubeScale = new Vector3(
                x / 1000.0f,
                0.1f,
                0.1f
            );
            transform.localScale = cubeScale;
            if (x < 400)
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