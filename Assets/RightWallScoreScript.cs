using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightWallScoreScript : MonoBehaviour
{
    public ScoreScript incrementScoreScript;
    private SceneScript scene;
    private BallController ball;
    // Start is called before the first frame update
    void Start()
    {
        incrementScoreScript = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreScript>();
        scene = GameObject.FindGameObjectWithTag("Scene").GetComponent<SceneScript>();
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            incrementScoreScript.IncrementScore(1);
            ball.ResetBallPosition();
        }
    }
}

