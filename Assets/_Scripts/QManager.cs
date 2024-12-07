using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QManager : MonoBehaviour
{
    public List<QuestionAndAnswers> QPop;
    public List<QuestionAndAnswers> QSci;
    public List<QuestionAndAnswers> QSpo;
    public List<QuestionAndAnswers> QArt;
    public List<QuestionAndAnswers> QGeo;
    public List<QuestionAndAnswers> QHis;
    
    public int Category = 7;
    public GameObject[] options;
    public GameObject QuizPanel;
    public int currentQuestion;

    public Text QuestionText;

    public void Done(){
        QuizPanel.SetActive(false);
    }

    void SetAnswers(int Category){
        switch(Category){
            case 1:
                for(int i = 0; i < options.Length; i++){
                options[i].GetComponent<AnswerScript>().isCorrect = false;
                options[i].transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text= QPop[currentQuestion].Answers[i];

                if(QPop[currentQuestion].CorrectAnswer == i+1){
                    options[i].GetComponent<AnswerScript>().isCorrect = true;
                }
                }
            break;
            case 2:
                for(int i = 0; i < options.Length; i++){
                options[i].GetComponent<AnswerScript>().isCorrect = false;
                options[i].transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text= QSci[currentQuestion].Answers[i];

                if(QSci[currentQuestion].CorrectAnswer == i+1){
                    options[i].GetComponent<AnswerScript>().isCorrect = true;
                }
                }
            break;
            case 3:
                for(int i = 0; i < options.Length; i++){
                options[i].GetComponent<AnswerScript>().isCorrect = false;
                options[i].transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text= QSpo[currentQuestion].Answers[i];

                if(QSpo[currentQuestion].CorrectAnswer == i+1){
                    options[i].GetComponent<AnswerScript>().isCorrect = true;
                }
                }
            break;
            case 4:
                for(int i = 0; i < options.Length; i++){
                options[i].GetComponent<AnswerScript>().isCorrect = false;
                options[i].transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text= QArt[currentQuestion].Answers[i];

                if(QArt[currentQuestion].CorrectAnswer == i+1){
                    options[i].GetComponent<AnswerScript>().isCorrect = true;
                }
                }
            break;
            case 5:
                for(int i = 0; i < options.Length; i++){
                options[i].GetComponent<AnswerScript>().isCorrect = false;
                options[i].transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text= QGeo[currentQuestion].Answers[i];

                if(QGeo[currentQuestion].CorrectAnswer == i+1){
                    options[i].GetComponent<AnswerScript>().isCorrect = true;
                }
                }
            break;
            case 6:
                for(int i = 0; i < options.Length; i++){
                options[i].GetComponent<AnswerScript>().isCorrect = false;
                options[i].transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text= QHis[currentQuestion].Answers[i];

                if(QHis[currentQuestion].CorrectAnswer == i+1){
                    options[i].GetComponent<AnswerScript>().isCorrect = true;
                }
                }
            break;
        }
    }

    public void GenerateQuestion(int Category){
        switch(Category){
            case 1:
                currentQuestion = Random.Range(0, QPop.Count);

                QuestionText.text = QPop[currentQuestion].Questions;
                SetAnswers(1);
                QuizPanel.SetActive(true);
            break;
            case 2:
                currentQuestion = Random.Range(0, QSci.Count);

                QuestionText.text = QSci[currentQuestion].Questions;
                SetAnswers(2);
                QuizPanel.SetActive(true);
            break;
            case 3:
                currentQuestion = Random.Range(0, QSpo.Count);

                QuestionText.text = QSpo[currentQuestion].Questions;
                SetAnswers(3);
                QuizPanel.SetActive(true);
            break;
            case 4:
                currentQuestion = Random.Range(0, QArt.Count);

                QuestionText.text = QArt[currentQuestion].Questions;
                SetAnswers(4);
                QuizPanel.SetActive(true);
            break;
            case 5:
                currentQuestion = Random.Range(0, QGeo.Count);

                QuestionText.text = QGeo[currentQuestion].Questions;
                SetAnswers(5);
                QuizPanel.SetActive(true);
            break;
            case 6:
                currentQuestion = Random.Range(0, QHis.Count);

                QuestionText.text = QHis[currentQuestion].Questions;
                SetAnswers(6);
                QuizPanel.SetActive(true);
            break;
        }

    }
}
