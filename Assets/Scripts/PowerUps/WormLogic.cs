using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WormLogic : MonoBehaviour
{

    [SerializeField] private BoxCollider2D _gridarea;
  
    [SerializeField] private SnakeMovement _snake;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<SnakeMovement>() != null && collision.gameObject.GetComponent<MovementForSecondSnake>() != null)
        {
            _snake.Decrease_Score();
            _snake.shrink();
            RandomPositionofFood();
        }
    }



    private void Start()
    {
        StartCoroutine(RepositionOfWorm());
    }
    public void RandomPositionofFood()
    {
        Bounds bounds = this._gridarea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }



    private IEnumerator RepositionOfWorm()
    {
        while (true)
        {
            RandomPositionofFood();  // Call the function to set a new position
            yield return new WaitForSeconds(3);  // Wait 2 seconds before moving again
        }
    }
}
