using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRespawn : MonoBehaviour
{
    [SerializeField] private Transform ball;
    [SerializeField] private Transform respawnPoint;
    public GameObject ballprefab;

    void OnTriggerEnter(Collider other)
    {
        Instantiate(ballprefab, respawnPoint);
        Destroy(other.gameObject);
    }

}
