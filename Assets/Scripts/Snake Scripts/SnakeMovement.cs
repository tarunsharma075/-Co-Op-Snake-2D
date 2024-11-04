using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    private float speed = 5f; // Movement speed
    private Vector2 direction; // Direction of movement
    private bool _movingvertical;
    private int AxisDirection;

    private void Awake()
    {
        // Start moving to the left initially
        direction = Vector2.left; // Move left initially
        _movingvertical = false; // Initially, horizontal movement is allowed
        AxisDirection = 1;
    }

    private void Update()
    {
        SnakeMove();
    }

    private void SnakeMove()
    {
        if (!_movingvertical) // Horizontal movement
        {
            Vector3 _newpos = transform.position;

            // Move horizontally based on direction
            _newpos += (Vector3)direction * speed * Time.deltaTime;
            transform.position = _newpos;

            // Check for input to change direction and set rotation
            if (Input.GetKeyDown(KeyCode.D) && direction != Vector2.right)
            {
                direction = Vector2.right;
                transform.rotation = Quaternion.Euler(0, 0, 180); // Set rotation for right
            }
            else if (Input.GetKeyDown(KeyCode.A) && direction != Vector2.left)
            {
                direction = Vector2.left;
                transform.rotation = Quaternion.Euler(0, 0, 0); // Set rotation for left
            }

            // Switch to vertical movement if W or S is pressed
            if (Input.GetKeyDown(KeyCode.W))
            {
                _movingvertical = true;
                transform.rotation = Quaternion.Euler(0, 0, 90); // Rotate for upward movement
                AxisDirection = 1;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                _movingvertical = true;
                transform.rotation = Quaternion.Euler(0, 0, -90); // Rotate for downward movement
                AxisDirection = -1;
            }
        }
        else // Vertical movement
        {
            Vector3 newPosition = transform.position;
            newPosition.y += speed * AxisDirection * Time.deltaTime;
            transform.position = newPosition;

            // Switch to horizontal movement if A or D is pressed
            if (Input.GetKeyDown(KeyCode.A))
            {
                _movingvertical = false;
                direction = Vector2.left;
                transform.rotation = Quaternion.Euler(0, 0, 0); // Set rotation for left
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                _movingvertical = false;
                direction = Vector2.right;
                transform.rotation = Quaternion.Euler(0, 0, 180); // Set rotation for right
            }
        }
    }
}
