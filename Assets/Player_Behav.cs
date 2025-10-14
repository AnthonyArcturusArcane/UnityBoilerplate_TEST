using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behav : MonoBehaviour
{

    void Update()
    {
        var rb = GetComponent<Rigidbody>();
        Vector3 vel = rb.velocity;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector3(5F,vel.y,vel.z);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector3(-5F, vel.y, vel.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0f, 12f, 0f);
        }
    }
}
