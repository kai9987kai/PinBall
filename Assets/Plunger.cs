using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Plunger : MonoBehaviour
{
    //This variable is used to control the launch of the ball to make sure we can only fire
    //it once.
    public bool launch = true;
    //This is used to detect the launch key being pressed.
    public bool keypressed = false;
    //We need to grab the physics attached to the Ball object
    public Rigidbody myRigidbody;
    //Set up a vector3 with the following values it is a Vector3 pointing forwards and
    //slightly up (this is because we will be tilting the table 10 degrees (as pinball
    //tables are tilted) so if it is not aimed up slightly it hits the table at an angle and
    //bounces off).
    //NOTE: this assumes the Z axis is pointing away from you down the table. Make sure
    //your table is orientated correctly or the ball will fly off in the wrong direction.
    public Vector3 Direction = new Vector3(0, 10, 50);
    void Start()
    {
        //Grab the Rigidbody physics of the object, we are doing this by dragging the
        //object onto the variable in the inspector.
        myRigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        // If the l key is pressed.
        if (Input.GetKeyDown("l"))
        {
            keypressed = true;
        }
    }
    void FixedUpdate()
    {
        while ((launch == true) && (keypressed == true))
        {
            //Apply an impulse force, basically a kick N.B. the size of the force is
            //dictated by the size of the Vector3.
            myRigidbody.AddForce(Direction, ForceMode.Impulse);
            // Set launch to false so we can’t apply force to the ball again while it is moving.
            launch = false;
        }
    }
}