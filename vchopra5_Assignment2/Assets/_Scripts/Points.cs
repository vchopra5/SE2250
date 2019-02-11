using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    void Start()
    {

    }

    private static int playerScore = 0;
    public Text score;

    private void Update()
    {
        score.text = "Score: " + playerScore;
    }
    public static void updatePlayerScore(int value)
    {
        playerScore += value;

    }
}
