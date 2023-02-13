using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage3 : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerStay2D(Collider2D other)
    {
        Player3 controller = other.GetComponent<Player3>();
  

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
