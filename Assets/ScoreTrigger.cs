using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreTrigger : MonoBehaviour
{
    public ScoreScript incrementScoreScript;
    private BallController ball;
    // Start is called before the first frame update
    void Start()
    {
        incrementScoreScript = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreScript>();
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallController>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            incrementScoreScript.IncrementScore(2);
            ball.ResetBallPosition();
        }
    }
}
