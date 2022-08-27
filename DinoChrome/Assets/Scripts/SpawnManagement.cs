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
    [SerializeField] private float TimeSpawnDown;
    [SerializeField] private float SpawnRateDown;
    [SerializeField] private float TimeSpawnUp;
    [SerializeField] private float SpawnRateUp;
    void Start()
    {
        InvokeRepeating("SpawnEnemiesDown", TimeSpawnDown, SpawnRateDown);
        InvokeRepeating("SpawnEnemiesUp", TimeSpawnUp, SpawnRateUp);
    }

    void Update()
    {
        
    }

    private void SpawnEnemiesDown()
    {
        Vector3 spawnPos = new Vector3(0, 0, 0);
        spawnPos = new Vector3(SpotDown.transform.position.x, SpotDown.transform.position.y, 0);

        GameObject downEnemy = Instantiate(EnemyDown, spawnPos, gameObject.transform.rotation);
    }

    private void SpawnEnemiesUp()
    {
        Vector3 spawnPosTwo = new Vector3(0, 0, 0);
        spawnPosTwo = new Vector3(SpotUp.transform.position.x, SpotUp.transform.position.y, 0);

        GameObject upEnemy = Instantiate(EnemyUp, spawnPosTwo, gameObject.transform.rotation);
    }
}
