using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    public Tiles StartingTile;
    DiceRoller Dice;
    public GameObject BonusDice;
    TotalDisplay totalToMove;
    public Tiles currentTile;
    Tiles finalTile = null;
    Tiles[] moveQueue;
    int moveQueueIndex = -1;
    Vector3 targetPos;
    Vector3 velocity = Vector3.zero;
    float smoothTime = .1f;
    public QManager Quiz;

    void Start(){
        Dice = GameObject.FindObjectOfType<DiceRoller>();
        totalToMove = GameObject.FindObjectOfType<TotalDisplay>();
    }

    void Update(){
        if(Vector3.Distance(this.transform.position ,targetPos) > 0.01f){
            this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPos, ref velocity, smoothTime);
        } else {
            if(moveQueue != null && moveQueueIndex < moveQueue.Length){
                SetTargetPos(moveQueue[moveQueueIndex].transform.position);
                moveQueueIndex++;
            }
        }

        this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPos, ref velocity, smoothTime);
    }

    void SetTargetPos(Vector3 pos){
        targetPos = pos;
        velocity = Vector3.zero;
    }

    void OnMouseUp(){
        Debug.Log("Clicked");

        if(Dice.doneRolling == false){
            return;
        }

        int spacesToMove = totalToMove.Total;

        if(spacesToMove == 0){
            return;
        }

        moveQueue = new Tiles[spacesToMove];

        for(int i = 0; i < spacesToMove; i++){
            if(currentTile == null){
                finalTile = StartingTile;
            } else {
                finalTile = finalTile.NextTile[0];

            }

            moveQueue[i] = finalTile;
        }

        totalToMove.Total = 0;
        Dice.rolledNoMove = false;
        Dice.doneRolling = false;
        if(BonusDice.activeInHierarchy){
            BonusDice.SetActive(false);
        }

        Quiz.GenerateQuestion(finalTile.Type);

        moveQueueIndex = 0;
        currentTile = finalTile;
    }
}
