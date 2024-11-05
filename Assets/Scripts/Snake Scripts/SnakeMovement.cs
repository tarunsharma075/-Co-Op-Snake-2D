using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    private Vector3 _direction = Vector2.left;
    [SerializeField] private int speed = 5;

    private void Update()
    {
        Vector3 newpos = transform.position;
        newpos += _direction * speed * Time.deltaTime; // Move in the direction vector

        transform.position = newpos; // Update the position of the snake

        if (Input.GetKeyDown(KeyCode.W))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _direction = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _direction = Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _direction = Vector2.left;
        }
    }
}
