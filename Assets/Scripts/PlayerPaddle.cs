using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    // Executes every single frame of the game (update) so is commonly used for checking inputs
   private void Update()
   {
       if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
       {
           _direction = Vector2.up;
       } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
   }

    // Not called every frame. Called at fixed time interval, so is associated with physics
    // Because physics is based on a set time interval usually
    // Rigid body makes this object into a physics object
   private void FixedUpdate() 
   {
       if (_direction.sqrMagnitude != 0)
       {
           _rigidbody.AddForce(_direction.normalized * this.speed);
       }
   }
}
