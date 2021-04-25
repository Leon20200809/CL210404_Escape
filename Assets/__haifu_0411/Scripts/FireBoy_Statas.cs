using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBoy_Statas : MonoBehaviour
{
    public int spells;
    public int hp;
    public int mp;

    GameManager gameManager;

    public void SetupFireBoy(GameManager gameManager)
    {
        this.gameManager = gameManager;
    }

}
