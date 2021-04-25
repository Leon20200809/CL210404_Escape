using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using creatorslabs.espacevr.demo;

public class GameManager : MonoBehaviour
{
    public UIManager uIManager;
    public FireBoy_Statas fireBoy_Statas;
    public SimpleMove fireBoy_Control;

    [SerializeField]
    GameClear gameClearObjPrefab;
    [SerializeField]
    Transform gameClearTran;

    [SerializeField]
    CanvasGroup canvasGroupGameOver;

    [SerializeField]
    CanvasGroup canvasGroupGameClear;

    float timeLimit = 0;
    public bool isGameOver = false;
    public bool isGameClear = false;
    public bool isCreateClearFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        fireBoy_Statas.SetupFireBoy(this);
    }

    // Update is called once per frame
    void Update()
    {
        timeLimit += Time.deltaTime;
        int hPdecrease = ((int)timeLimit);

        if (isGameClear == true) return;

        if (hPdecrease == 1 && isGameOver == false)
        {
            HPdecrease(1);
            timeLimit = 0;
        }


        if (fireBoy_Statas.spells >= 4 && isCreateClearFlag == false)
        {
            isCreateClearFlag = true;
            Create__BookOfSpells();
        }
    }

    /// <summary>
    /// １秒ごとにHPを1減少
    /// </summary>
    /// <param name="h"></param>
    void HPdecrease(int h)
    {

        fireBoy_Statas.hp -= h;
        uIManager.DisplayFoodsUICounts();

        if (fireBoy_Statas.hp <= 0)
        {
            isGameOver = true;
            canvasGroupGameOver.DOFade(1, 3f);
            fireBoy_Control.SwitchIsControl(true);
        }
    }

    /// <summary>
    /// クリアアイテムの生成
    /// </summary>
    public void Create__BookOfSpells()
    {
        GameClear gameClearObj = Instantiate(gameClearObjPrefab, gameClearTran);
        gameClearObj.SetupGameClear(this);
        
    }

    /// <summary>
    /// ゲームクリア文字の表示
    /// </summary>
    public void DisplayGameClear()
    {
        canvasGroupGameClear.DOFade(1, 3f);
        fireBoy_Control.SwitchIsControl(true);
    }
}
