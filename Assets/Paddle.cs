using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D paddleRigidBody;
    public float speed;
    public SceneScript scene;
    
    void Awake()
    {
        scene = GameObject.FindGameObjectWithTag("Scene").GetComponent<SceneScript>();
        paddleRigidBody = GetComponent<Rigidbody2D>();
    }

}
