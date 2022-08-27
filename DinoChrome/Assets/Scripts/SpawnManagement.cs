using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagement : MonoBehaviour
{
    [SerializeField] private GameObject EnemyDown;
    [SerializeField] private GameObject EnemyUp;
    [SerializeField] private GameObject SpotDown;
    [SerializeField] private GameObject SpotUp;
    [SerializeField] private float TimeSpawn;
    [SerializeField] private float SpawnRate;
    void Start()
    {
        InvokeRepeating("SpawnEnemies", TimeSpawn, SpawnRate);
    }

    void Update()
    {
        
    }

    private void SpawnEnemies()
    {
        Vector3 spawnPos = new Vector3(0, 0, 0);
        spawnPos = new Vector3(SpotDown.transform.position.x, SpotDown.transform.position.y, 0);

        Vector3 spawnPosTwo = new Vector3(0, 0, 0);
        spawnPosTwo = new Vector3(SpotUp.transform.position.x, SpotUp.transform.position.y, 0);

        GameObject downEnemy = Instantiate(EnemyDown, spawnPos, gameObject.transform.rotation);
        GameObject upEnemy = Instantiate(EnemyUp, spawnPosTwo, gameObject.transform.rotation);
    }
}
