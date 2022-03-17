using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    // This is called every time an object collides with something else
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If ball collides with surface
        Ball ball = collision.gameObject.GetComponent<Ball>();
        // If it was the ball that collided with this game object
        if (ball != null) {
            // normal is vector pointing away at the surface
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
        }
    }
    
}
