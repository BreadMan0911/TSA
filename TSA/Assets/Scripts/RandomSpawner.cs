using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    Vector2 randomPosition;
    public float xRange = 34.36f;
    public float yRange = 8.91f;

    void Start()
    {
        float xPosition = Random.Range(0 - xRange, 0 + xRange);
        float yPosition = Random.Range(0 - yRange, 0 + yRange);
        randomPosition = new Vector2(xPosition, yPosition);
        transform.position = randomPosition;
    }

     void OnCollisionEnter(Collision other)
    {
        while (other.gameObject.tag == ("Ground"))
        {
             float xPosition = Random.Range(0 - xRange, 0 + xRange);
            float yPosition = Random.Range(0 - yRange, 0 + yRange);
            randomPosition = new Vector2(xPosition, yPosition);
            transform.position = randomPosition;
        }
    }
}