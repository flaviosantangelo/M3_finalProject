using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Enemy
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Enemy _enemyPrefab;

    private void Start()
    {
        StartCoroutine(SpawnEnemyRoutine());
    }

    private IEnumerator SpawnEnemyRoutine()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(20f);
        }
    }

    private void SpawnEnemy()
    {
        Instantiate(_enemyPrefab, _spawnPoint.position, _spawnPoint.rotation);
    }
}
