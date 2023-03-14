using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody2D paddleRigidbody;
    public float bound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleKeyboardInput();

        var position = transform.position;
        if (position.y >= bound)
        {
            position.y = bound;
        } else if (position.y <= -bound)
        {
            position.y = -bound;
        }
       
        transform.position = position;
    }

    void HandleKeyboardInput()
    {

        if (Input.GetKey(KeyCode.W))
        {
            paddleRigidbody.velocity = Vector2.up * speed;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            paddleRigidbody.velocity = Vector2.down * speed;
        }

        else
        {
            paddleRigidbody.velocity = Vector2.up * 0;
        }
    }
}
