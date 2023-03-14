using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int player1Score;
    public int player2Score;
    public Text score1;
    public Text score2;

    [ContextMenu("Increase score")]
    public void IncrementScore(int player)
    {
        if (player == 1)
        {
            player1Score += 1;
            score1.text = player1Score.ToString();
        }else
        {
            player2Score += 1;
            score2.text = player2Score.ToString();
        }
    }

}
