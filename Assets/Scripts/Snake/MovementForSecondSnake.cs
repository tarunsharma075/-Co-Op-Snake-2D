using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.AI;
using System.Collections.Generic;
using System;
using UnityEngine.SocialPlatforms.Impl;
public class MovementForSecondSnake : MonoBehaviour
{
   private Vector2 _direction = Vector2.right;
    [SerializeField] private FoodLogic _foodLogic;
    private List<Transform> _segments;

    [SerializeField] private Transform _tailsegments;
    [SerializeField] private BoxCollider2D _snakecollider;

    [SerializeField] private UIManager score;




    private void Start()
    {
        
        _segments = new List<Transform>();
        _segments.Add(this.transform);
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            _direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {


            _direction = Vector2.right;

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            _direction= Vector2.left;
        }


    }


    private void FixedUpdate()
    {

        for (int i = _segments.Count - 1; i > 0; i--)
        {

            _segments[i].position = _segments[i-1].position;
        
        }
        this.transform.position = new Vector3(

            Mathf.Round(this.transform.position.x) + _direction.x,

            Mathf.Round(this.transform.position.y) + _direction.y,
            0.0f

            );
     
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<FoodLogic>())
        {
            _foodLogic.OnHitPossitionChange();
            Grow();

        }
    }


    private void Grow()
    {
        Transform PreFabSegmentTail = Instantiate(this._tailsegments);
        PreFabSegmentTail.position = _segments[_segments.Count - 1].position;
        _segments.Add(PreFabSegmentTail); 

    }

    public void shieldactivated()
    {
        StartCoroutine(shield());
    }

    private IEnumerator shield()
    {
        _snakecollider.enabled = false;
        yield return new WaitForSeconds(3);
        _snakecollider.enabled = true;
    }

    public void shrink()
    {
        for (int i = _segments.Count - 1; i >0; i--)
        {
            Destroy(_segments[i].gameObject);
            _segments.RemoveAt(i);
        }
    }

    public  void Decrease_Score()
    {
        score.decrease_score(10);
    }
}
