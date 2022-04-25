using System;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;

    public virtual bool CanShoot()
    {
        return true;
    }

    public void Shoot(Vector2 direction)
    {
        if (CanShoot() == false)
            throw new InvalidOperationException();

        direction.Normalize();
        Bullet bullet = Instantiate(_bullet);
        bullet.transform.position = transform.position;
        bullet.Initialize(direction);
    }

}
