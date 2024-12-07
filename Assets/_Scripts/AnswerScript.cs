using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QManager Quiz;
    public Score scoreCounter;
    public AudioClip CorrectDing;
    public AudioClip IncorrectBuzz;

    void Start(){
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreCounter = scoreGO.GetComponent<Score>();
    }

    public void Answer(){
        if(isCorrect){
            scoreCounter.score += 1;
            AudioSource.PlayClipAtPoint(CorrectDing, new Vector3(0,10,0));
        } else {
            scoreCounter.score -= 1;
            AudioSource.PlayClipAtPoint(IncorrectBuzz, new Vector3(0,10,0));
        }
        Quiz.Done();
    }
}
