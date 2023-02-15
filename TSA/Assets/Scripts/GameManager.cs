using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour

{
    private int score;
    public TextMeshProUGUI scoreText;
   
    void Start()
    {
        score = 0;
        UpdateScore(0);
    }

    private void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score; 
    }

    
    void Update()
    {
        
    }
}
