using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LeftFlipper : MonoBehaviour
{
    // Set various parameters in the flipper hinge physics.
    public float leftFlipperZero = 0f;
    public float leftFlipperFire = 120f;
    public float allFlipperStrength = 20000f;
    public float allFlipperDamp = 0f;
    // This is an extension of rigidbody physics.
    HingeJoint leftFlipperHinge;
    JointSpring spring = new JointSpring();
    void Start()
    {
        // We need to get the hinge component and tell it to use the spring setting
        // and set some of the parameters.
        leftFlipperHinge = GetComponent<HingeJoint>();
        leftFlipperHinge.useSpring = true;
        spring.spring = allFlipperStrength;
        spring.damper = allFlipperDamp;
    }
    void FixedUpdate()
    {
        // if we hit the key the flipper moves
        if (Input.GetKey("a"))
        {
            // When you fire the flipper move it to its max position
            spring.targetPosition = leftFlipperFire;
            //Debug.Log("a pressed");
        }
        else
        {
            //Return to off position
            spring.targetPosition = leftFlipperZero;
        }
        // These can get a bit unreliable unless updated continuously.
        // Go into THE rigid body component for both the hinge and flipper and set
        // Collision detection to Continuous dynamic.
        leftFlipperHinge.spring = spring;

        leftFlipperHinge.useLimits = true;
    }
}