using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    public float speed = 200.0f;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }
    // This will called the first frame and only once in this object's lifecycle
    private void Start()
    {
        ResetPosition();
    }

    private void AddStartingForce()
    {
        
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(1.0f, 0.5f);
        Vector2 direction = new Vector2(x, y);
        // Provides the ball with a vector, which is basically reverse kinematics. 
        // The vector provides the direction of travel while the speed provides the "magnitude" basically, not sure how they deal with the internal magnitude
        // Of the given vector though
        _rigidBody.AddForce(this.speed * direction.normalized);
    }
    private void FixedUpdate()
    {
        Debug.Log(_rigidBody.velocity.normalized);
        _rigidBody.velocity = _rigidBody.velocity.normalized * 5;
    }
    public void AddForce(Vector2 force)
    {
        _rigidBody.AddForce(force);
    }

    // Reset the ball when someone scores
    public void ResetPosition() {
        // Why vector3? 
        _rigidBody.position = Vector3.zero;
        _rigidBody.velocity = Vector3.zero;
        AddStartingForce();
    }

}
