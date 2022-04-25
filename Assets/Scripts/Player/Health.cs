using UnityEngine;

public class Health : MonoBehaviour
{
    public int Value => _value;

    [SerializeField] private int _value;

    public void TakeDamage(int damage)
    {
        _value -= damage;

        if (_value <= 0)
            _value = 0;
    }
}
