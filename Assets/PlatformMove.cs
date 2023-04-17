using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public int moveSpeed = 10;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        rb.velocity = transform.forward * -1 * moveSpeed *Time.fixedDeltaTime;
    }
}
