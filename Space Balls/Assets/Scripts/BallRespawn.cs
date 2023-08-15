using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRespawn : MonoBehaviour
{
    [SerializeField] private Transform ball;
    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        ball.transform.position = respawnPoint.transform.position;
    }

}
