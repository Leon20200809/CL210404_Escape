using UnityEngine;
using UniRx;

public class MoveWithCommand : MonoBehaviour
{
    [SerializeField] private TestSubject _testSubject;

    void Start()
    {
        _testSubject.commandSub.Subscribe(s =>
            {
                if (s == "forward")
                {
                    transform.Translate(0, 0, 1, Space.Self);
                }
                else if (s == "backward")
                {
                    transform.Translate(0, 0, -1, Space.Self);
                }
                else if (s == "left")
                {
                    transform.Translate(-1, 0, 0, Space.Self);
                }
                else if (s == "right")
                {
                    transform.Translate(1, 0, 0, Space.Self);
                }
                else if (s == "red")
                {
                    GetComponent<Renderer>().material.color = Color.red;
                }
            },
            er => { Debug.Log("エラー発生の場合: " + er.Message); },
            () => { Debug.Log("これ以上のキー入力は受け付けません"); }).AddTo(this);
    }
}