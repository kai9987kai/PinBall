using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Plunger_update : MonoBehaviour
{
    // This will launch the ball onto the table when the ball collides with the launch box
    // trigger.
    // You may need experiment with different values for Direction this value may be a little on
public Vector3 Direction = new Vector3(0, 10, 50);
    // When the ball collides with the LaunchBox We fire it down the launch channel.
    void OnTriggerEnter(Collider object_hit)
    {
        // We have latched onto the object that hit the relaunch box above with the
        // OnTriggerEnter and called in 'object_hit' in this case it’s going to be the ball.
        // We then grab this objects rigidbody and tell it to apply an impulse force.
        object_hit.attachedRigidbody.AddForce(Direction, ForceMode.Impulse);
    }
}