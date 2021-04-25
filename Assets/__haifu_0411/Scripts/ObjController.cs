using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[RequireComponent(typeof(BoxCollider))]

public class ObjController : MonoBehaviour
{
    GameManager gameManager;
    UIManager uIManager;
    FireBoy_Statas fireBoy_Statas;

    public bool isBonusPoint;

    private void Start()
    {
        GameObject gameObjectUIManager = GameObject.FindGameObjectWithTag("UIManager");
        uIManager = gameObjectUIManager.GetComponent<UIManager>();
        GameObject gameObjectFireBoy = GameObject.FindGameObjectWithTag("Player");
        fireBoy_Statas = gameObjectFireBoy.GetComponent<FireBoy_Statas>();
    }

    //public void SetupObjController(GameManager gameManager, UIManager uIManager)
    //{
    //    this.gameManager = gameManager;
    //    this.uIManager = uIManager;
    //}


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            uIManager.DestroyCount++;

            isBonusPoint = false;
            JudgeBonusPoint();

            uIManager.objName.Add(this.gameObject.name);
            uIManager.tagName.Add(this.gameObject.tag);
            Debug.Log(this.gameObject.name);


            if (this.gameObject.tag == "books")
            {
                if (isBonusPoint == true)
                {
                    fireBoy_Statas.spells += uIManager.bookPoint * 2;
                    Debug.Log("2倍");

                }
                else
                {
                    fireBoy_Statas.spells += uIManager.bookPoint;
                }
                uIManager.DisplayBooksUICounts();
                SoundManager.instance.PlaySE(SoundDataSO.SeType.Get);

            }
            else if (this.gameObject.tag == "foods")
            {
                fireBoy_Statas.hp += uIManager.foodPoint;
                uIManager.DisplayFoodsUICounts();

            }
            else if (this.gameObject.tag == "bottles")
            {
                fireBoy_Statas.mp += uIManager.bottlesPoint;
                uIManager.DisplayBottlesUICounts();

            }
            else
            {
                return;
            }


            Destroy(this.gameObject);
            DebugGetItems();
        }

    }

    /// <summary>
    /// 総取得アイテム名表示
    /// </summary>
    void DebugGetItems()
    {
        //for (int i = 0; i < uIManager.objName.Count; i++)
        //{
        //    Debug.Log(uIManager.objName[i]);
        //}

        foreach (string s in uIManager.objName.Reverse<string>().Take(3))
        {
            Debug.Log(s + " ");
        }


    }

    /// <summary>
    /// ボーナスポイント評価判定
    /// </summary>
    /// <returns></returns>
    public void JudgeBonusPoint()
    {
        if (uIManager.tagName.Count == 0) return;

        if (uIManager.tagName[0] == this.gameObject.tag)
        {
            Debug.Log("ボーナス倍率");

            isBonusPoint = true;
        }
        else
        {
            isBonusPoint = false;
        }

    }

}
