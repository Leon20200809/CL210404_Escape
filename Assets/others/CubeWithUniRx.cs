using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;


public class CubeWithUniRx : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool colorFLag = false;
        Material cubeMat = GetComponent<Renderer>().material;

        // Observable.Interval(System.TimeSpan.FromSeconds(1))
        //     .Subscribe(_ =>
        //     {
        //         Debug.Log("called");
        //         colorFLag = !colorFLag;
        //         if (colorFLag)
        //         {
        //             cubeMat.color = Color.red;
        //         }
        //         else
        //         {
        //             cubeMat.color = Color.green;
        //         }
        //     })
        //     .AddTo(gameObject);

        this.UpdateAsObservable()
            .Where(_ => Input.GetKeyDown(KeyCode.Space)) //whereは、ある条件が成立したときだけ先に流れる
            .Subscribe(_ =>
            {
                colorFLag = !colorFLag;
                if (colorFLag)
                {
                    cubeMat.color = Color.red;
                }
                else
                {
                    cubeMat.color = Color.green;
                }
            });


        this.UpdateAsObservable()
            .Where(_ => Input.GetKeyDown(KeyCode.UpArrow)) //whereは、ある条件が成立したときだけ先に流れる
            .Subscribe(_ =>
            {
                transform.Translate(0, 0, 1, Space.Self);
            });
    }

    // Update is called once per frame
    void Update()
    {
    }
}