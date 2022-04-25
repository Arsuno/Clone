using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _direction;

    public void Initialize(Vector2 direction)
    {
        _direction = direction.normalized;
    }

    private void Update()
    {
        transform.position += _speed * Time.deltaTime * _direction;
    }
}