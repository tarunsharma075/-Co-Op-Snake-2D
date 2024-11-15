using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.AI;
using System.Collections.Generic;
using System;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
public class SnakeMovement : MonoBehaviour
{
    private Vector2 _direction;
    [SerializeField] private FoodLogic _foodLogic;
    [SerializeField] private WormLogic _wormlogic;
    [SerializeField] private Shield  _shieldLogic;
    [SerializeField] private Banana _bananalogic;
    private List<Transform> _segments;

    [SerializeField] private Transform _tailsegments;
    [SerializeField] private BoxCollider2D _snakecollider;

    [SerializeField] private UIManager score;
    [SerializeField] private GameObject _shieldActivationIndicator;
    [SerializeField] private Snaketype Player;



    private void Awake()
    {
        if (Player == Snaketype.snakeone)
        {
            _direction = Vector2.right;

        }
        else if (Player == Snaketype.snaketwo) {
            _direction = Vector2.up;
        }
    }
    private void Start()
    {
        
        _segments = new List<Transform>();
        _segments.Add(this.transform);
    }

    public enum Snaketype
    {
       snakeone,
       snaketwo,
    }


    private void Update()
    {
        if (Player == Snaketype.snakeone)
        {
            if (Input.GetKeyDown(KeyCode.W) && _direction != Vector2.down)
            {
                _direction = Vector2.up;
            }
            else if (Input.GetKeyDown(KeyCode.S) && _direction != Vector2.up)
            {
                _direction = Vector2.down;
            }
            else if (Input.GetKeyDown(KeyCode.D) && _direction != Vector2.left)
            {
                _direction = Vector2.right;
            }
            else if (Input.GetKeyDown(KeyCode.A) && _direction != Vector2.right)
            {
                _direction = Vector2.left;
            }
        }
        else if (Player == Snaketype.snaketwo)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && _direction != Vector2.down)
            {
                _direction = Vector2.up;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && _direction != Vector2.up)
            {
                _direction = Vector2.down;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && _direction != Vector2.left)
            {
                _direction = Vector2.right;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && _direction != Vector2.right)
            {
                _direction = Vector2.left;
            }
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
        if (collision.gameObject.GetComponent<FoodLogic>()) { 
        
            
                SoundManager.Instance.PlaySoundEfffect(SoundManager.Sounds.point);
                _foodLogic.OnHitPositionChange();
                IncreaseScore();
                Grow();

            
        }

        if (collision.gameObject.GetComponent<WormLogic>())
        {
           
            
                SoundManager.Instance.PlaySoundEfffect(SoundManager.Sounds.worm);
                _wormlogic.ChangeInPosition();
                DecreaseScore();
                shrink();
                
            
           
        }

        if (collision.gameObject.GetComponent<Shield>())
        {
            
                SoundManager.Instance.PlaySoundEfffect(SoundManager.Sounds.shield);

                _shieldLogic.ChangethePosition();
                shieldactivated();
            
        }
        if (collision.gameObject.GetComponent<Banana>())
        {
                SoundManager.Instance.PlaySoundEfffect(SoundManager.Sounds.banana);
                _bananalogic.ChangethePosition();
                score.IncreaseScore(30);

           

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
        if (Player == Snaketype.snakeone)
        {
            _snakecollider.enabled = false;
            _shieldActivationIndicator.SetActive(true);
            yield return new WaitForSeconds(3);
            _snakecollider.enabled = true;
            _shieldActivationIndicator.SetActive(false);
        }else if(Player == Snaketype.snaketwo)
        {
            _snakecollider.enabled = false;
            _shieldActivationIndicator.SetActive(true);
            yield return new WaitForSeconds(3);
            _shieldActivationIndicator.SetActive(false);
            _snakecollider.enabled = true;
        }
    }

    public void shrink()
    {
        for (int i = _segments.Count - 1; i >0; i--)
        {
            Destroy(_segments[i].gameObject);
            _segments.RemoveAt(i);
        }
    }

    public  void DecreaseScore()
    {
            score.DecreaseScore(50);
            shrink();
    }

    public void IncreaseScore()
    { 
         score.IncreaseScore(10);
    }
}
