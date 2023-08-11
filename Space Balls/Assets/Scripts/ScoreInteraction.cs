using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ScoreInteraction : MonoBehaviour
{
    public ScorindDisplay score;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "tennis_ball")
        {
            score.AddScore(1);
        }
    }
}

    