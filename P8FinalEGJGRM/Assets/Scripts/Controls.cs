using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public Animator animator;
    private float y;
    public float sideStrafeSpeed = 3f;
    public float backwardSpeed = 2.5f;
    public float forwardSpeed = 5f;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
            animator.SetBool("isWalking", true);
        }
        if (!Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * backwardSpeed * Time.deltaTime);
            animator.SetBool("isWalking", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * sideStrafeSpeed * Time.deltaTime);
            animator.SetBool("isWalking", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * sideStrafeSpeed * Time.deltaTime);
            animator.SetBool("isWalking", true);
        }
        
        y = Input.GetAxis("Mouse X");
        transform.Rotate(0, y, 0, Space.World);
    }
}
