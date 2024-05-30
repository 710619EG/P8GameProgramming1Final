using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public float forwardSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        }
            
    }
}
