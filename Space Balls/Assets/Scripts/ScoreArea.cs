using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour {
    public GameObject effectObject;

    void Start () {
        effectObject.SetActive (false);
    }

    void OnTriggerEnter (Collider otherCollider) {
        GameObject ball = otherCollider.gameObject;
        if (ball.name=="tennis_ball") {
            effectObject.SetActive (true);
        }
    }
}
