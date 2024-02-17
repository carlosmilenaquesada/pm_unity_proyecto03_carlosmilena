using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    public GameObject camion;
    private float startDelay = 2;
    private float repeatRate = 2;
    public PlayerController playerControllerScript;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

   

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            int numeroRandom = Random.Range(0, 3);
            Instantiate(obstaclePrefab[numeroRandom], camion.transform.position, obstaclePrefab[numeroRandom].transform.rotation);
            Debug.Log(numeroRandom);
        }
    }
}
