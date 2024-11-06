using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodLogic : MonoBehaviour
{
    [SerializeField] private BoxCollider2D _gridarea;
    [SerializeField]  private UIManager _changeinscore;

    private void Start()
    {
        RandomPositionofFood();
    }


    private void RandomPositionofFood()
    {
      Bounds bounds = this._gridarea.bounds;

        float x = Random.Range(bounds.min.x,bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y),0.0f);
    }


    public void OnHitPossitionChange()
    {
        RandomPositionofFood();
        _changeinscore.IncreaseScore(10);
    }
}
