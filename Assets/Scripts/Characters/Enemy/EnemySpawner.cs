using System.Collections;
using UnityEngine;

public class EnemySpawner : Enemy
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private GameObject _summonEffect;
    private float _summonDuration = 1f;

    private void Start()
    {
        StartCoroutine(SpawnEnemyRoutine());
    }

    private IEnumerator SpawnEnemyRoutine()
    {
        while (true)
        {
            yield return StartCoroutine(SummonAndSpawn());
            yield return new WaitForSeconds(20f);
        }
    }

    private IEnumerator SummonAndSpawn()
    {
       _summonEffect.SetActive(true);
       
        yield return new WaitForSeconds(_summonDuration);
        Instantiate(_enemyPrefab, _spawnPoint.position, _spawnPoint.rotation);
    }
}