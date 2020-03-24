using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rig : MonoBehaviour
{
    public Rigidbody rb;

    public Transform t;

    public float rotX = 0f, rotY = 0f, rotZ = 0f, rotationDelta = 7;

    public Vector3 defaultScale = new Vector3();

    private Vector3 rotation = new Vector3(), scaleChange = new Vector3();

    void start()
    {
        
    }

    // Using FixedUpdate instead of Update because I am using physics
    void FixedUpdate()
    {
        rotationDelta = 4;
        defaultScale.Set(5f, 5f, 5f);

        // Rotation controls
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
        { rotX = 0; rotY = 0; rotZ = 0;
            t.localScale = defaultScale;
        }

        // Scale controls
        if (Input.GetKey("y"))
            scaleChange.Set(0.1f, 0.1f, 0.1f);
        else if (Input.GetKey("h"))
            scaleChange.Set(-0.1f, -0.1f, -0.1f);
        else
            scaleChange.Set(0f, 0f, 0f);

        t.localScale += scaleChange;
        rotation.Set(rotX, rotY, rotZ);
        t.localEulerAngles = rotation;
        rb.useGravity = false;

    }
}
