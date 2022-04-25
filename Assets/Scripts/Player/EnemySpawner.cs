using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform _circleOrigin;
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private float _timeBetweenSpawns;
    [SerializeField] private float _minRadius;
    [SerializeField] private float _maxRadius;


    private void Start()
    {
        StartCoroutine(Spawn());
    }



    IEnumerator Spawn()
    {
        Instantiate(_enemyPrefab, GetRandomPosition(), Quaternion.identity);
        yield return new WaitForSeconds(_timeBetweenSpawns);
        StartCoroutine(Spawn());
    }

    private Vector2 GetRandomPosition()
    {
        float pi = Random.Range(0, 2 * Mathf.PI);
        float radius = Random.Range(_minRadius, _maxRadius);
        Vector2 position = new Vector2(Mathf.Cos(pi), Mathf.Sin(pi)) * radius;
        return position + (Vector2)_circleOrigin.position;
    }
}
