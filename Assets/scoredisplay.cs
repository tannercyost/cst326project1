using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoredisplay : MonoBehaviour
{
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Left: " + score.leftScore + " Right: " + score.rightScore;
    }
}
