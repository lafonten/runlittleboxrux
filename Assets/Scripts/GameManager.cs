using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float score;
    public Text scoreText;
   
    public GameObject deadScreen;

    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }


    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void Dead() 
    {
            deadScreen.SetActive(true);
        
    }
}
