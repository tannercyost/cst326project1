using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public int modifier = 115;

    // Start is called before the first frame update
    void Awake()
    {
        Rigidbody ball = transform.gameObject.GetComponent<Rigidbody>();
        ball.velocity = Vector3.right * modifier * Time.deltaTime;
    }

    public void Restart()
    {
        modifier = 115;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody ball = transform.gameObject.GetComponent<Rigidbody>();
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        if (collision.gameObject.name == "PaddleRight") // if ball hits right
        {
            if (ball.transform.position.z > rb.transform.position.z)
            {
                Vector3 launchAngle = new Vector3(1, 0, 1) * modifier * Time.deltaTime;
                //Debug.Log("High");
                //ball.AddForce(launchAngle);
                ball.velocity = launchAngle;
            }
            if (ball.transform.position.z <= rb.transform.position.z)
            {
                Vector3 launchAngle = new Vector3(1, 0, -1) * modifier * Time.deltaTime;
                //Debug.Log("Low");
                //ball.AddForce(launchAngle);
                ball.velocity = launchAngle;
            }
        }

        if (collision.gameObject.name == "PaddleLeft") // if ball hits left paddle
        {
            if (ball.transform.position.z > rb.transform.position.z)
            {
                Vector3 launchAngle = new Vector3(-1, 0, 1) * modifier * Time.deltaTime;
                //Debug.Log("High");
                //ball.AddForce(launchAngle);
                ball.velocity = launchAngle;
            }
            if (ball.transform.position.z <= rb.transform.position.z)
            {
                Vector3 launchAngle = new Vector3(-1, 0, -1) * modifier * Time.deltaTime;
                //Debug.Log("Low");
                //ball.AddForce(launchAngle);
                ball.velocity = launchAngle;
            }
        }

        modifier += 10;
    }
}
