using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    private float x, y;
    public float neckSpeed = -2f;
    public float sideStrafeSpeed = 3f;
    public float backwardSpeed = 2.5f;
    public float forwardSpeed = 5f;
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * backwardSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * sideStrafeSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * sideStrafeSpeed * Time.deltaTime);
        }
        y = Input.GetAxis("Mouse X");
        x = Input.GetAxis("Mouse Y") * neckSpeed;
        transform.Rotate(0, y, 0, Space.World);
    }
}
