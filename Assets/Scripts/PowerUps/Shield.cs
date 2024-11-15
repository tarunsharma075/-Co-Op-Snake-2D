using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;



public class Shield : MonoBehaviour
{

    [SerializeField] private BoxCollider2D _gridArea;

    public void ChangethePosition()
    {
        RandomPositionOfShield();
    }

    private void RandomPositionOfShield()
    {
        Bounds bounds = _gridArea.bounds;
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private IEnumerator RepositionOfBanana()
    {
        while (true)
        {
            RandomPositionOfShield(); // Set a new position
            yield return new WaitForSeconds(3);  // Wait 3 seconds before moving again
        }
    }

    private void Start()
    {
        
    }

}
