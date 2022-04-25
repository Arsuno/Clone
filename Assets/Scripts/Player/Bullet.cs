using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _damage;

    private Vector3 _direction;

    public void Initialize(Vector2 direction)
    {
        _direction = direction.normalized;
    }

    private void Update()
    {
        transform.position += _speed * Time.deltaTime * _direction;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent(out Health health) == true)
            health.TakeDamage(_damage);

        Debug.Log(health.Value);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.TryGetComponent(out Health health) == true)
            health.TakeDamage(_damage);

        Debug.Log(health.Value);
    }
}
