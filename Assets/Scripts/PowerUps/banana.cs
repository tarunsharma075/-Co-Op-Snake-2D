using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class banana : MonoBehaviour
{
    [SerializeField] private UIManager score;
    [SerializeField] private BehaviourOfPowerups _chnageinpos;


    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.GetComponent<SnakeMovement>() != null)
        {
            _chnageinpos.RandomPositionOfPowerups();
            score.IncreaseScore(30);
          
            
        }
            
    }

   
}
