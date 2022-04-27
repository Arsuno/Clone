using UnityEngine;

public class AutoAttack : MonoBehaviour
{
    [SerializeField] private Weapon _weapon;
    [SerializeField] private float _radius;

    private void Update()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position, _radius);

        
        if (collider != null && collider.GetComponent<Enemy>() != null)
        {
            Vector2 direction = collider.transform.position - transform.position;
            _weapon.Shoot(direction);
        }
    }
}
