using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rig : MonoBehaviour
{
    public Rigidbody rb;

    // Using FixedUpdate instead of Update because I am using physics
    void FixedUpdate()
    {
        rb.AddForce(0,0,2000 * Time.deltaTime);
        
    }
}
