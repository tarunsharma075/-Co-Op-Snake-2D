using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class SnakeMovement : MonoBehaviour
{
   private Vector2 _direction = Vector2.left;
    [SerializeField] private FoodLogic _foodLogic;
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

            _direction= Vector2.left;
        }


    }


    private void FixedUpdate()
    {
        this.transform.position = new Vector3(

            Mathf.Round(this.transform.position.x) + _direction.x,

            Mathf.Round(this.transform.position.y) + _direction.y,
            0.0f

            );
     
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<FoodLogic>())
        {
            _foodLogic.OnHitPossitionChange();

        }
    }
}
