using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyVelocityTest : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(speed, 0, 0);
    }
}
