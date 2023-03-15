using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D paddleRigidBody;
    public float speed;
    // Start is called before the first frame update
    void Awake()
    {
        paddleRigidBody = GetComponent<Rigidbody2D>();
    }

}
