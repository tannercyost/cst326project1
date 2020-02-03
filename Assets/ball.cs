using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    int modifier = 10;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody ball = transform.gameObject.GetComponent<Rigidbody>();
        ball.AddForce(Vector3.right * modifier);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody ball = transform.gameObject.GetComponent<Rigidbody>();
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        if (collision.gameObject.name == "PaddleRight")
        {
            Debug.Log("Right paddle collision");
            ball.AddForce(Vector3.left * modifier);
        }
        if (collision.gameObject.name == "PaddleLeft")
        {
            Debug.Log("Left paddle collision");
            ball.AddForce(Vector3.right * modifier);
        }
        modifier += 5;
    }
}
