using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Paddle
{
    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleKeyboardInput();  
    }

   private void HandleKeyboardInput()
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

    private void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
        {
            paddleRigidBody.AddForce(direction * this.speed);
        }
    }
}
