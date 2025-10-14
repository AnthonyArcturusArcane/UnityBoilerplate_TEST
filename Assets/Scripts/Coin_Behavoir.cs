using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Behavoir : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        // Test if other object is player

        //find the Level_Manager and call Collect_Coin Function
        // find an object which have Level_Manager behavoir attachted to it and call Collect_Coin
        FindObjectOfType<Level_Manager>().Collect_Coin();

        Destroy(this.gameObject);
    }


}
