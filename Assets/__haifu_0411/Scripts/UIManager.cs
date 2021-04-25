using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    [SerializeField]
    GameManager gameManager;

    [SerializeField]
    Text txtDestroyCount;
    int destroyCount;

    [SerializeField]
    Text txtBooksCount;

    [SerializeField]
    Text txtFoodsCount;

    [SerializeField]
    Text txtBottlesCount;

    [SerializeField]
    Text txtInfo;

    public string infoMessage;

    public int bookPoint;
    public int foodPoint;
    public int bottlesPoint;

    [SerializeField]
    FireBoy_Statas fireBoy_Statas;

    

    // Start is called before the first frame update
    void Start()
    {
        DisplayBooksUICounts();
        DisplayFoodsUICounts();
        DisplayBottlesUICounts();
    }

    public List<string> objName = new List<string>();
    public List<string> tagName = new List<string>();

    public int DestroyCount
    {
        set
        {
            destroyCount = value;
            txtDestroyCount.text = "破壊数：" + destroyCount.ToString();
        }

        get
        {
            return destroyCount;
        }
    }

    public void DisplayBooksUICounts()
    {
        txtBooksCount.text = "Spells：" + fireBoy_Statas.spells.ToString();
    }
    public void DisplayFoodsUICounts()
    {
        txtFoodsCount.text = "HP：" + fireBoy_Statas.hp.ToString();
    }
    public void DisplayBottlesUICounts()
    {
        txtBottlesCount.text = "MP：" + fireBoy_Statas.mp.ToString();
    }

    public void DisplayInfo()
    {
        txtInfo.text = infoMessage;
    }

}
