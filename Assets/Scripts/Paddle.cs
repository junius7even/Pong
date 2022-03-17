using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;
    protected Rigidbody2D _rigidbody;

    // Only gets called once in theentire lifetime of an object
    // Used to initialize things
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        
    }
    
}
