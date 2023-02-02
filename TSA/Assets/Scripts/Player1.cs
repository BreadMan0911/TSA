using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed = 3.0f;
    public bool jump = true;
    public float jumpForce = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         if (Input.GetKey(KeyCode.A))  
         {
             transform.Translate(Vector2.left * Time.deltaTime * speed);
         }
         if (Input.GetKey(KeyCode.D))
         {
             transform.Translate(Vector2.right * Time.deltaTime * speed);
         }
         if (Input.GetKey(KeyCode.W) && jump != false)
         {
             transform.Translate(Vector2.up * Time.deltaTime * jumpForce);
         }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == ("Ground"))
        {
            jump = true;
        }
    }
    void OnCollisionExit(Collision other)
    {
        if(other.gameObject.tag == ("Ground"))
        {
            jump = false;
        }
    }
}