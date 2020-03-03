using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rig : MonoBehaviour
{
    public Rigidbody rb;

    public Transform t;

    public float rotX = 0f, rotY = 0f, rotZ = 0f, rotationDelta = 2f;

    private Vector3 rotation = new Vector3();

    void start()
    {

    }

    // Using FixedUpdate instead of Update because I am using physics
    void FixedUpdate()
    {

        if (Input.GetKey("u"))
            rotX += rotationDelta;
        if (Input.GetKey("j"))
            rotX -= rotationDelta;
        if (Input.GetKey("i"))
            rotY += rotationDelta;
        if (Input.GetKey("k"))
            rotY -= rotationDelta;
        if (Input.GetKey("o"))
            rotZ += rotationDelta;
        if (Input.GetKey("l"))
            rotZ -= rotationDelta;
        if (Input.GetKey("r"))
        { rotX = 0; rotY = 0; rotZ = 0; }

        rotation.Set(rotX, rotY, rotZ);
        t.localEulerAngles = rotation;
        rb.useGravity = false;
        //rb.AddForce(0,0,2000 * Time.deltaTime);

    }
}
