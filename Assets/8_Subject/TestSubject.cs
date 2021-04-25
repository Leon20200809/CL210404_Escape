using System;
using UnityEngine;
using UniRx;

public class TestSubject : MonoBehaviour
{
    public Subject<string> commandSub { get; private set; } = new Subject<string>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            commandSub.OnNext("forward");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            commandSub.OnNext("backward");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            commandSub.OnNext("left");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            commandSub.OnNext("right");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            commandSub.OnNext("red");
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            commandSub.OnCompleted();
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            commandSub.OnError(new Exception("重大なエラー！！！！"));
            // commandSub.OnError(new Exception());
        }
    }
}