using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreIntThree : MonoBehaviour
{
    public ScorindDisplay score;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "tennis_ball")
        {
            score.AddScore(3);
        }
    }
}
