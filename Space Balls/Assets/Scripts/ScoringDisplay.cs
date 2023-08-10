using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScorindDisplay : MonoBehaviour
{
    public Text ScoreText;
    public int score = 0;
    public int maxScore;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void AddScore(int newScore)
    {
        score += newScore;
    }

    public void UpdateScore()
    {
        ScoreText.text = "Score 0" + score;
    }
        
    // Update is called once per frame
    void Update()
    {
        UpdateScore();

    }
}
