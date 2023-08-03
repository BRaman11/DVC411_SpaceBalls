using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour{

    public GameObject effectObject;

    void Start () {
        effectObject.SetActive (false);
    }

    void OnTriggerEnter (Collider otherCollider) {
        GameObject ball = otherCollider.gameobject;
        if (if ball.name=="Ball") {
            effectObject.SetActive (true);
        }
    }
}

