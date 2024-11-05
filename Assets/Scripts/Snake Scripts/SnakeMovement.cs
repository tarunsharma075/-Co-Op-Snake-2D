using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    private Vector3 _direction = Vector2.left;
   

    private void Update()
    {


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

    private void FixedUpdate()
    {
        this.transform.position = new Vector3(
            // rounding is done to make sure our snake is sort remain to a grid
            Mathf.Round(this.transform.position.x) + _direction.x,
             Mathf.Round(this.transform.position.y) + _direction.y,
             0.0f
            );
    }
}

        
