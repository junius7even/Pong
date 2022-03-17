using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    // Remember that this gets called every frame so its always dealing with physics
    private void FixedUpdate()
    {
        // Moving towards the right
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.ball.position.y > this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            } else if (this.ball.position.y < this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        } else if (this.ball.velocity.x < 0.0f) // When the ball is moving left towards the player, move in the opposite direction?
        {
            if (_rigidbody.position.y >  0.0f) 
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            } else if (_rigidbody.position.y <  0.0f) 
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
