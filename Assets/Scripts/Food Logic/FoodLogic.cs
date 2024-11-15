using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FoodLogic : MonoBehaviour
{
    [SerializeField] private BoxCollider2D _gridarea;



    private Coroutine FoodCoroutine;

    private void Start()
    {
        RandomPositionOfFood();
        StartCoroutine(RepositionFoodRoutine());

    }

    public  void RandomPositionOfFood()
    {
        Bounds bounds = this._gridarea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }
    private IEnumerator RepositionFoodRoutine()
    {
        while (true)
        {
            RandomPositionOfFood();  // Call the function to set a new position
            yield return new WaitForSeconds(3);  // Wait 2 seconds before moving again
        }
    }
    public void OnHitPositionChange()
    {
        RandomPositionOfFood();
       
       


    }

    


}