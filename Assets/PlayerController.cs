using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Paddle
{
    private Vector2 direction;
    // Update is called once per frame
    void Update()
    {
        HandleKeyboardInput();  
    }

   private void HandleKeyboardInput()
    {
        if (scene.GetIsGameActive())
        {

            if (Input.GetKey(KeyCode.W))
            {
                direction = Vector2.up;
            }

            else if (Input.GetKey(KeyCode.S))
            {
                direction = Vector2.down;
            }
            else
            {
                direction = Vector2.zero;
            }
        }
    }

    private void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0 && scene.GetIsGameActive())
        {
            paddleRigidBody.AddForce(direction * this.speed);
        }
    }
}
