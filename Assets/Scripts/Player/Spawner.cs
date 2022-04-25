using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _timeBetweenSpawns;

    private Vector2 _spawnPosition;



    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        GetRandomPosition();
        Instantiate(_enemyPrefab, _spawnPosition, Quaternion.identity);
        yield return new WaitForSeconds(_timeBetweenSpawns);
        StartCoroutine(Spawn());
    }

    private Vector2 GetRandomPosition()
    {
        _spawnPosition = new Vector2(Random.Range(-10, 10), Random.Range(-4, 4));
        return _spawnPosition;
    }
}
