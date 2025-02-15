using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEventColorChange : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //this would make the spheres change color when player bumps into them 
        if (collision.gameObject.CompareTag("Player"))
        {
            float randomRed = Random.Range(0.0f, 1.0f);
            float randomGreen = Random.Range(0.0f, 1.0f);
            float randomBlue = Random.Range(0.0f, 1.0f);

            Color randomColor = new Color(randomRed, randomGreen, randomBlue);

            GetComponent<MeshRenderer>().material.color = randomColor;

        }
    }

}

