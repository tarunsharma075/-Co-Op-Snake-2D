using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;



    public class Shield : MonoBehaviour
    {

        [SerializeField] private SnakeMovement _snake;

        private void OnTriggerEnter2D(Collider2D collision)
        {

            if (collision.gameObject.GetComponent<SnakeMovement>() != null)
            {
                _snake.shieldactivated();

            }
        }
    }
