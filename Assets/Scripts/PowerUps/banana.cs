using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class banana : MonoBehaviour
{
    [SerializeField] private UIManager score;
   


    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.GetComponent<SnakeMovement>() != null)
        {
            score.IncreaseScore(30);
            
        }
            
    }
}
