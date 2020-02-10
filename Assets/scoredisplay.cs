using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoredisplay : MonoBehaviour
{
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score.leftScore);
        Debug.Log(score.rightScore);
        scoreText.text = "Left: " + score.leftScore + " Right: " + score.rightScore;
    }
}
