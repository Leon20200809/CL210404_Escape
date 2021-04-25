using System.IO;
using System.Net;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class TestFactoryMethods : MonoBehaviour
{
    void Start()
    {
        // Observable.Start(() => //時間がかかる処理がおわったら、結果をOnNext()で通知するときに使う
        //     {
        //         //時間がかかる処理の例、例えばwebでAPI叩くなど
        //         var req = (HttpWebRequest) WebRequest.Create("https://google.co.jp");
        //         var res = (HttpWebResponse) req.GetResponse();
        //         using (var reader = new StreamReader(res.GetResponseStream()))
        //         {
        //             return reader.ReadToEnd();
        //         }
        //     })
        //     .ObserveOnMainThread() //このさきの処理を別スレッドからUnityメインスレッドに切り替える
        //     .Subscribe(x => Debug.Log(x)).AddTo(this);
        // // ==================================================        
        // //3秒後に1回だけメッセージを発行して終了
        // Observable.Timer(System.TimeSpan.FromSeconds(3))
        //     .Subscribe(_ => Debug.Log("3秒たちました"));

        // // ==================================================
        // //5秒後から1秒おきにメッセージを発行しつづける
        // Observable.Timer(System.TimeSpan.FromSeconds(5), System.TimeSpan.FromSeconds(1))
        //     .Subscribe(_ => Debug.Log("1秒間隔で実行します"))
        //     .AddTo(gameObject);
        // // ==================================================
        // //1秒おきにメッセージを発行しつづける
        // Observable.Interval(System.TimeSpan.FromSeconds(2))
        //     .Subscribe(_ => Debug.Log("2秒間隔で実行します"))
        //     .AddTo(gameObject);
        // ==================================================
        //Observable
        //    .Return(Unit.Default) //何かがおこってからDelayが始まるので、何も無いときは Retunr(Unit.Default)をいれてやる
        //    .Delay(System.TimeSpan.FromSeconds(2))
        //    .Subscribe(_ => Debug.Log("2秒おくれて実行します"))
        //    .AddTo(gameObject);

        // //なので、この書き方はエラーになります
        // Observable
        //     .Delay(System.TimeSpan.FromSeconds(2))
        //     .Subscribe(_ => Debug.Log("2秒おくれて実行します"))
        //     .AddTo(gameObject);
        // //==================================================             
        // //　UpdateAsObservable()を使う場合は
        // //        using UniRx.Triggers;が必要になります
        // this.UpdateAsObservable()
        //     .Subscribe(_ => Debug.Log("Update!"));
        // // ==================================================
        // 組み合わせてみた例
        // this.UpdateAsObservable()
        //     // .Where(_ => Input.anyKeyDown) //whereは、ある条件が成立したときだけ先に流れる
        //     .Where(_ => Input.GetKeyDown(KeyCode.Space)) //whereは、ある条件が成立したときだけ先に流れる
        //     .Delay(System.TimeSpan.FromSeconds(1.0f))
        //     .Subscribe(_ => Debug.Log("扉を開ける"));
        //
        // this.UpdateAsObservable()
        //     .Where(_ => Input.GetKeyDown(KeyCode.Escape)) //whereは、ある条件が成立したときだけ先に流れる
        //     .Delay(System.TimeSpan.FromSeconds(1.0f))
        //     .Subscribe(_ => Debug.Log("ゲームオーバー"));


    }
}