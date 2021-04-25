using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClear : MonoBehaviour
{
    GameManager gameManager;

    public void SetupGameClear(GameManager gameManager)
    {
        this.gameManager = gameManager;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(gameManager.fireBoy_Statas.mp >= 10)
            {
                gameManager.isGameClear = true;
                gameManager.DisplayGameClear();
            }
            else
            {
                gameManager.uIManager.DisplayInfo();
            }
        }
    }

}
