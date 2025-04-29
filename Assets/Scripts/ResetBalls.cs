using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBalls : MonoBehaviour
{
    public GameObject ballPrefab; // Reference to the ball prefab
    public Transform ballSpawnPoint; // Reference to the spawn point for the ball

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); // Destroy the ball that entered
        Instantiate(ballPrefab, ballSpawnPoint.position, ballSpawnPoint.rotation); // Instantiate a new ball at the spawn point
}
}