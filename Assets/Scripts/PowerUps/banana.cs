using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class banana : MonoBehaviour
{
    [SerializeField] private UIManager scoreforsnakeone;
    [SerializeField] private UIManager scoreforsnaketwo;
    [SerializeField] private BehaviourOfPowerups _chnageinpos;


    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.GetComponent<SnakeMovement>() != null)
        {
            _chnageinpos.RandomPositionOfPowerups();
            scoreforsnakeone.IncreaseScoreforsnakeone(30);


        }
        else if (collision.gameObject.GetComponent<MovementForSecondSnake>() != null)
        {
            _chnageinpos.RandomPositionOfPowerups();
            scoreforsnaketwo.IncreaseScoreforsnaketwo(30);
        }

    }
   
}
