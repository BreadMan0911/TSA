using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    public float speed = 2.5f;
    Vector2 directionRight = Vector2.right;
    Vector2 directionLeft = Vector2.left;
    private float leftBound = -13.343f;
    private float rightBound = -9.565f;
    private bool goingLeft = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        if(goingLeft == true)
        {
            transform.Translate(directionLeft * Time.deltaTime * speed);
            if(transform.position.x <= leftBound)
            {
                goingLeft = false;
            }
        }
        if(goingLeft==false)
        {
            transform.Translate(-directionLeft * Time.deltaTime * speed);
            if(transform.position.x >= rightBound)
            {
                goingLeft = true;
            }
        }
    }
}
