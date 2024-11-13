using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class banana : MonoBehaviour
{
  
    [SerializeField] private BoxCollider2D _gridarea;

    public void ChangethePosition()
    {
        RandomPositionOfBanana();
    }

    private void RandomPositionOfBanana()
    {
        Bounds bounds = _gridarea.bounds;
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private IEnumerator RepositionOfBanana()
    {
        while (true)
        {
            RandomPositionOfBanana(); // Set a new position
            yield return new WaitForSeconds(3);  // Wait 3 seconds before moving again
        }
    }

}
