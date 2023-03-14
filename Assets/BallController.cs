using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody2D ballRigidBody;
    private Vector2 startSpeed;
    public float extraSpeed;
    public float maxSpeed;
    private int hitCounter=0;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("BallStartDirection", 2);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            if (Mathf.Abs(ballRigidBody.velocity.x) < maxSpeed && Mathf.Abs(ballRigidBody.velocity.y) < maxSpeed)
            {
                IncrementHitCounter();
                IncreaseBallSpeed();
            }
        }
    }

    private Vector2 GetRandomStartVelocity()
    {
        float rand = Random.Range(0, 3);
        Vector2 velocity;
        if (rand <= 1)
        {
            velocity = new Vector2(20, -15);
        }
        else
        {
            velocity = new Vector2(-20, -15);
        }
        return velocity;
    }

    private void BallStartDirection()
    {
        ballRigidBody.AddForce(GetRandomStartVelocity());
    }

    

    private void IncreaseBallSpeed()
    {
        ballRigidBody.AddForce(extraSpeed * hitCounter * ballRigidBody.velocity);
    }

    public void IncrementHitCounter()
    {
            hitCounter++;
    }

    public void ResetBallPosition()
    {
        ballRigidBody.position = Vector3.zero;
        ballRigidBody.velocity = Vector3.zero;

        BallStartDirection();
    }
}
