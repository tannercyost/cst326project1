using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public static int leftScore = 0;
    public static int rightScore = 0;
    public GameObject ball;

    void OnTriggerEnter(Collider col)
    {
        if (transform.name == "LeftGoal")
        {
            Debug.Log("Right player won.");
            rightScore += 1;
            ball.transform.position = new Vector3(0, 0, 0);
        }

        if (transform.name == "RightGoal")
        {
            Debug.Log("Left player won.");
            leftScore += 1;
            ball.transform.position = new Vector3(0, 0, 0);
        }

        Debug.Log("Score -- Left: " + leftScore + " Right: " + rightScore);

        if (leftScore >= 11)
        {
            ball.transform.position = new Vector3(0, 0, 0);
            Debug.Log("Game over, left player won.");
            leftScore = 0;
            rightScore = 0;
        } 
        else if (rightScore >= 11)
        {
            ball.transform.position = new Vector3(0, 0, 0);
            Debug.Log("Game over, right player won.");
            leftScore = 0;
            rightScore = 0;
        }
        else
        {
            ball.transform.position = new Vector3(0, 0, 0);
        }

    }
}
