using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int Lives;
    public int score;
    public Text livesText;
    public Text scoreText;
    void Start()
    {
        livesText.text = "Lives : " + Lives;
        scoreText.text = "Score : " + score;
    }
    void Update()
    {
        
    }
    public void ChangeLives(int life){
        Lives+=life;

        livesText.text = "Lives : " + Lives;
    }
    public void ChangeScore(int sc){
        score+=sc;
        scoreText.text = "Score : " +score ;
    }
}
