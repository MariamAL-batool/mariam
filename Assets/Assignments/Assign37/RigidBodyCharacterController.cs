using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyCharacterController : MonoBehaviour
{
    Rigidbody rigidbody;
    Vector3 input;
    float speed = 5f;
    bool jump = false;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        input = input.normalized * speed;
        input.y = rigidbody.velocity.y;
        if (Input.GetKeyUp(KeyCode.Space))
        {
            jump = true;
        }
    }
    void FixedUpdate()
    {
        rigidbody.freezeRotation = true;
        rigidbody.velocity = input;
        if (jump)
        {
            rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse);
            jump = false;
        }
        else
        {
            rigidbody.velocity = input;
        }
    }
}
