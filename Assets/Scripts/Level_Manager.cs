using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Manager : MonoBehaviour
{
    [SerializeField]
    int Coins_Collected = 0;

    public void Collect_Coin()
    {
        Coins_Collected++;
    }

    public int Get_Coins_Collected()
    {
        return Coins_Collected;
    }
}
