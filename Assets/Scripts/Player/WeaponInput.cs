using UnityEngine;

public class WeaponInput : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Weapon _weapon;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            if (_weapon.CanShoot() == true)
            {
                Vector2 mouseWorldPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
                _weapon.Shoot((mouseWorldPosition - (Vector2)transform.position).normalized);
            }
        }
    }
}
