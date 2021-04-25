using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class CubeBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.OnTriggerEnterAsObservable().Subscribe(c => { GetComponent<Renderer>().material.color = Color.green; });
        this.OnTriggerExitAsObservable().Subscribe(c => { GetComponent<Renderer>().material.color = Color.red; });
    }

    // Update is called once per frame
    void Update()
    {
    }
}