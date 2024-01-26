using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]private int currentRound = 1;
    [SerializeField]private int enemiesRemaining = 0;
    [SerializeField]private GameObject enemyPrefab;
    [SerializeField]private Transform spawnPoint;
    [SerializeField]private int enemiesPerRound = 5;

    private void Awake()
    {
        spawnPoint = GetComponent<Transform>();
    }
    private void Start()
    {
        StartRound();
    }

    private void StartRound()
    {
        enemiesRemaining = enemiesPerRound;
        SpawnEnemies();
    }

    private void SpawnEnemies()
    {
        for (int i = 0; i < enemiesRemaining; i++)
        {
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }

    public void Update()
    {
        if (enemiesRemaining > 0)
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

            if (enemies.Length == 0)
            {
                currentRound++;
                enemiesPerRound += 5;
                StartRound();
            }
        }
    }

    public void EnemyDestroyed()
    {
        enemiesRemaining--;
    }
}
