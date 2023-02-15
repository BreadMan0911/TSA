using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle1 : MonoBehaviour
{
    public float speed = 3.0f;
    public bool jump = true;
    public float jumpForce = 5.0f;
    public int health = 1;
    int currentHealth;
    public Transform respawnPosition;
    public bool gameOver = false;
    public float PlayerNumber1 = 1;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
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
         if (currentHealth < 1)
         {
              Destroy(gameObject);
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
    }
    void Respawn()
    {
        ChangeHealth(health);
        transform.position = respawnPosition.position;
    }
}
