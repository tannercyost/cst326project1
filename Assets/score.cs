using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    int leftScore = 0;
    int rightScore = 0;
    public GameObject newBall;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider col)
    {
        if (transform.name == "LeftGoal")
        {
            //Destroy(col.gameObject);
            Destroy(col.gameObject);
            Debug.Log("Right player won.");
            rightScore += 1;
        }

        if (transform.name == "RightGoal")
        {
            //Destroy(col.gameObject);
            Destroy(col.gameObject);
            Debug.Log("Left player won.");
            leftScore += 1;
        }
        Debug.Log("Score -- Left: " + leftScore + " Right: " + rightScore);

        if (leftScore >= 11)
        {
            Debug.Log("Game over, left player won.");
        } 
        else if (rightScore >= 11)
        {
            Debug.Log("Game over, right player won.");
        }
        else
        {
            Instantiate(newBall, new Vector3(0, 0, 0), Quaternion.identity);
        }

    }
}
