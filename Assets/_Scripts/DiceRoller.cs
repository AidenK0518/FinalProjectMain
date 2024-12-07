using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoller : MonoBehaviour
{
    public int[] DiceValues;
    public int DiceResult;
    public AudioClip SDiceRolling;
    public GameObject self;

    public bool doneRolling = false;
    public bool rolledNoMove = false;

    public Sprite[] NewDice;
    public Sprite[] Rolled1;
    public Sprite[] Rolled2;
    public Sprite[] Rolled3;
    public Sprite[] Rolled4;
    public Sprite[] Rolled5;
    public Sprite[] Rolled6;

    void Start(){
        DiceValues = new int[1];
    }

    public void NewTurn(){
        doneRolling = false;
    }

    public void Roll(){
        if(rolledNoMove == false){
            if(self.activeInHierarchy == true){
                DiceResult = 0;
                for(int i = 0; i < DiceValues.Length; i++){
                    DiceValues[i] = Random.Range(1, 7);
                    DiceResult += DiceValues[i];

                    switch(DiceResult){
                        case 1:
                        this.transform.GetChild(i).GetComponent<Image>().sprite = Rolled1[0];
                        break;

                        case 2:
                        this.transform.GetChild(i).GetComponent<Image>().sprite = Rolled2[0];
                        break;

                        case 3:
                        this.transform.GetChild(i).GetComponent<Image>().sprite = Rolled3[0];
                        break;

                        case 4:
                        this.transform.GetChild(i).GetComponent<Image>().sprite = Rolled4[0];
                        break;

                        case 5:
                        this.transform.GetChild(i).GetComponent<Image>().sprite = Rolled5[0];
                        break;

                        case 6:
                        this.transform.GetChild(i).GetComponent<Image>().sprite = Rolled6[0];
                        break;
                    }

                    AudioSource.PlayClipAtPoint(SDiceRolling, new Vector3(0,10,0));
                    doneRolling = true;
                    rolledNoMove = true;
                }

                Debug.Log("Rolled: " + DiceResult);
            }
        }
    }
}
