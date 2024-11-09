using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class ScreenWrapping : MonoBehaviour
{
    [SerializeField] private GameObject SnaekParentObj;
    private Rigidbody2D _myrigidbody;
    private void Awake()
    {
        _myrigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {  // get the position of the snake  in pixels

        Vector3 ScreenPos = Camera.main.WorldToScreenPoint(this.transform.position);
        // get the edges of screen in the world points 
        float RightSideOFTheScreen= Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,Screen.height)).x;
        float LeftSideOFTheScreen = Camera.main.ScreenToWorldPoint(new Vector2(0.0f,0.0f)).x;

        float BottonOfTheScreen = Camera.main.ScreenToWorldPoint(new Vector2(0.0f,0.0f)).y;
        float TopOfTheScreen = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,Screen.height)).y;


        if (ScreenPos.x > Screen.width)
        {
            transform.position = new Vector2(LeftSideOFTheScreen, this.transform.position.y);
        }
        else if (ScreenPos.x <= 0)
        {

            transform.position = new Vector2(RightSideOFTheScreen, this.transform.position.y);
        }
        else if (ScreenPos.y > Screen.height)
        {

            transform.position = new Vector2(this.transform.position.x, BottonOfTheScreen);
        }else if (ScreenPos.y <= 0)
        {

            transform.position = new Vector2(this.transform.position.x, TopOfTheScreen);
        }
        
            
    }

}
