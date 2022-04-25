using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private CharacterMovement _movement;
    private GameObject _player;

    private void Start()
    {
        _player = GameObject.Find("Player");
    }

    void Update()
    {
        _movement.MoveLooped(_player.transform.position - transform.position, Time.deltaTime);
    }
}
