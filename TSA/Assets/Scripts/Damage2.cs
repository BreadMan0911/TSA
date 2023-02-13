using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage2 : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerStay2D(Collider2D other)
    {
        Player2 controller = other.GetComponent<Player2>();
  

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
