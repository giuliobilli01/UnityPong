using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : Paddle
{
    protected Rigidbody2D ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // If the ball is going on the computer paddle
        if (ball.velocity.x > 0)
        {

            if (ball.position.y > transform.position.y)
            {
                paddleRigidBody.AddForce(Vector2.up * this.speed);
            }
            else if (ball.position.y < transform.position.y)
            {
                paddleRigidBody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            if (transform.position.y > 0)
            {
                paddleRigidBody.AddForce(Vector2.down * this.speed);
            }
            else if (transform.position.y < 0)
            {
                paddleRigidBody.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
