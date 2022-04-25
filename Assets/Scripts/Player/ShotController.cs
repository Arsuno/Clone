using UnityEngine;

public class ShotController : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _bulletFlySpeed;

    private Vector2 _startBulletPosition;
    private Vector2 _worldMousePosition;
    private Vector2 _mousePosition;
    private Vector2 _bulletFlyDirection;


    private void Update()
    {
        _mousePosition = Input.mousePosition;
        _startBulletPosition = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        _worldMousePosition = Camera.main.ScreenToWorldPoint(_mousePosition);
        _bulletFlyDirection = _worldMousePosition - _startBulletPosition;

        if (Input.GetMouseButtonDown(0) == true)
        {
            Shoot(_bulletFlyDirection, _bulletFlySpeed);
            Debug.Log(_startBulletPosition);
            Debug.Log(_worldMousePosition);
        }
    }

    private void BulletSpawn()
    {
        Instantiate(_bulletPrefab, _startBulletPosition, Quaternion.identity);
    }

    private void Shoot(Vector2 direction, float speed)
    {
        direction.Normalize();
        BulletSpawn();
        _bulletPrefab.transform.position += speed * Time.deltaTime * (Vector3)direction;
    }

    
}
