using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    public void MoveLooped(Vector2 direction, float deltatime)
    {
        direction.Normalize();
        transform.position += _speed * deltatime * (Vector3)direction;
    }

}
