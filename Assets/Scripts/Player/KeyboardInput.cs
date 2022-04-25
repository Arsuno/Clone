using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    [SerializeField] private CharacterMovement _movement;


    private void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
            _movement.MoveLooped(Vector2.up, Time.deltaTime);
    
        if (Input.GetKey(KeyCode.A) == true)
            _movement.MoveLooped(Vector2.left, Time.deltaTime);

        if (Input.GetKey(KeyCode.S) == true)
            _movement.MoveLooped(Vector2.down, Time.deltaTime);

        if (Input.GetKey(KeyCode.D) == true)
            _movement.MoveLooped(Vector2.right, Time.deltaTime);


    }

    

}
