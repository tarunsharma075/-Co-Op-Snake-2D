using System.Collections;
using UnityEngine;

public class WormLogic : MonoBehaviour
{
    [SerializeField] private BoxCollider2D _gridArea;
    [SerializeField] private SnakeMovement _snake;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<SnakeMovement>() != null || collision.gameObject.GetComponent<MovementForSecondSnake>() != null)
        {
            _snake.Decrease_Score();
            _snake.shrink();
            RandomPositionOfWorm();
        }
    }

    private void Start()
    {
        StartCoroutine(RepositionOfWorm());
    }

    private void RandomPositionOfWorm()
    {
        Bounds bounds = _gridArea.bounds;
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private IEnumerator RepositionOfWorm()
    {
        while (true)
        {
            RandomPositionOfWorm(); // Set a new position
            yield return new WaitForSeconds(3);  // Wait 3 seconds before moving again
        }
    }
}
