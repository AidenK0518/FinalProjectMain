using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalDisplay : MonoBehaviour
{
    public DiceRoller Dice1;
    public DiceRoller Dice2;
    public GameObject BonusDice;

    public int Total;

    void Update()
    {
        if(BonusDice.activeInHierarchy){
            Total = Dice1.DiceResult + Dice2.DiceResult;
        } else {
            Total = Dice1.DiceResult;
        }

        if(Dice1.doneRolling){
            GetComponent<Text>().text = "TOTAL: " + Total;
        } else {
            GetComponent<Text>().text = "Rolling...";
        }
    }
}
