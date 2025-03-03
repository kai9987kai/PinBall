using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RelaunchBall : MonoBehaviour
{
    // We need two references the ball and then point we are going to move the ball to.
    public GameObject Ball;
    public Transform SpawnPoint;
    // This will be used to control the physics of the ball.
    public Rigidbody Ball_physics;
    void OnCollisionEnter(Collision move_ball)
    {
        // When we hit the drain collision box the ball is moved to the slot in the launch
        // channel.
        // Debug.Log("collision detceted " + move_ball.gameObject.name);
        if (move_ball.gameObject.name == "Ball")
        {
            // Debug.Log("if statemt entetred");
            // Get control of the physics of the ball and connect it to 'Ball_physics'.
            Ball_physics = move_ball.gameObject.GetComponent<Rigidbody>();
            // Turn off the physics of the ball so we don’t upset the physics engine by just
            // moving the ball.
            Ball_physics.isKinematic = true;
            // Move the ball to the location of the SpawnPoint object.
            Ball.transform.position = SpawnPoint.transform.position;
            // Reset the physics of the ball now we have moved it.
            Ball_physics.isKinematic = false;
        }
    }
}