using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;



    public class Shield : MonoBehaviour
    {

        [SerializeField] private SnakeMovement _snake;
    [SerializeField] private BehaviourOfPowerups _chnageinpos;
    [SerializeField] private MovementForSecondSnake _snaketwo;

    private void OnTriggerEnter2D(Collider2D collision)
        {

            if (collision.gameObject.GetComponent<SnakeMovement>() != null)
            {
            
            _snake.shieldactivated();
            _chnageinpos.RandomPositionOfPowerups();




        }
        else if(collision.gameObject.GetComponent<MovementForSecondSnake>() != null)
        {
            _snaketwo.shieldactivated();
            _chnageinpos.RandomPositionOfPowerups();
        }
        }
    }
