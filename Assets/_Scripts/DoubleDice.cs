using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleDice : MonoBehaviour
{
    public GameObject BonusDice;

    public void Double(){
        if (BonusDice.activeInHierarchy == true){
            BonusDice.SetActive(false);
        } else {
            BonusDice.SetActive(true);
        }
    }
}
