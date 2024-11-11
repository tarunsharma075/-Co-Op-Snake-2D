using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeCollider : MonoBehaviour
{
    [SerializeField] private GameObject maingameobj;
    [SerializeField] private GameObject restartobj;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<ScreenWrapping>()!=null|| collision.gameObject.GetComponent<SnakeMovement>() != null)
        {
            maingameobj.SetActive(false);
            restartobj.SetActive(true);
           

        }
    }
}
