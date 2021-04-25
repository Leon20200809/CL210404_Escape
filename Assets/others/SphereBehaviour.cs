using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class SphereBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.OnCollisionEnterAsObservable().Subscribe(c =>
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        });
    }

    // Update is called once per frame
    void Update()
    {
    }
}