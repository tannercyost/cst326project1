using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputs : MonoBehaviour
{
    public float speed = 10;
    public Transform paddle;
    
    
    void Update()
    {
        if (Input.GetAxis("Vertical1") != 0 && paddle.name == "PaddleLeft") // detects WS and triggers left
        {
            float translation = Input.GetAxis("Vertical1") * speed;

            translation *= Time.deltaTime; // put in terms of time instead of frames

            // Move translation along the object's z-axis
            transform.Translate(0, 0, translation);
        }

        if (Input.GetAxis("Vertical2") != 0 && paddle.name == "PaddleRight") // detects up/down and triggers right
        {
            float translation = Input.GetAxis("Vertical2") * speed;

            translation *= Time.deltaTime; // put in terms of time instead of frames

            // Move translation along the object's z-axis
            transform.Translate(0, 0, translation);
        }
    }
}
