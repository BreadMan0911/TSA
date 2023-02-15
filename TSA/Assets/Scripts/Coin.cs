using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Coin : MonoBehaviour
{
    public float count = 0;
    Load3 load3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.CompareTag("Coin"))
        {
            Destroy(collider2D.gameObject);
            count += 1;
        }
        if (count == 5)
        {
           Debug.Log("Game Over!");
           SceneManager.LoadScene("game over");
        }

    }
    
}
