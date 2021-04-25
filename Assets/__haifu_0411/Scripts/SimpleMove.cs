using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace creatorslabs.espacevr.demo
{
    
    public class SimpleMove : MonoBehaviour
    {
        public float speed = 20; // 動く速さ
        public float rotationSpeed = 20; // 向きを変える速さ

        bool isControl = false;

        public UIManager uIManager;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (isControl) return;

            // カーソルキーの入力を取得
            var moveHorizontal = Input.GetAxis("Horizontal");
            var moveVertical = Input.GetAxis("Vertical");

            transform.Translate(0, 0, moveVertical * speed, Space.Self);
            transform.Rotate(0, moveHorizontal * rotationSpeed, 0, Space.Self);


            // // カーソルキーの入力に合わせて移動方向を設定
            // var movement = new Vector3(moveHorizontal, 0, moveVertical);
            //
            // // Ridigbody に力を与えて玉を動かす
            // rb.AddForce(movement * speed);


        }

        /// <summary>
        /// 制御切り替え（移動できるできない）
        /// </summary>
        /// <param name="isSwitch"></param>
        public void SwitchIsControl(bool isSwitch)
        {
            isControl = isSwitch;
        }

    }
}