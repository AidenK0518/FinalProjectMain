using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [Header("Dynamic")]
    public int score = 0;
    private Text uiText;

    void Start()
    {
        uiText = GetComponent<Text>();
    }

    void Update()
    {
        uiText.text = "Score: " + score.ToString("#,0");
    }
}
