using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle3 : MonoBehaviour
{
    public float speed = 3.0f;
    public bool jump = true;
    public float jumpForce = 5.0f;
    public int health = 1;
    int currentHealth;
    public Transform respawnPosition;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         if (Input.GetKey(KeyCode.J))  
         {
             transform.Translate(Vector2.left * Time.deltaTime * speed);
         }
         if (Input.GetKey(KeyCode.L))
         {
             transform.Translate(Vector2.right * Time.deltaTime * speed);
         }
         if (Input.GetKey(KeyCode.I) && jump != false)
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
    public void ChangeHealth(int amount) 
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, health);
        if (amount < 0)
        {
            if(currentHealth == 0)
            gameOver = true;
        }
    }
}
