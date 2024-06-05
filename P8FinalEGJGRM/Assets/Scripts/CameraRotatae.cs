using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotatae : MonoBehaviour
{
    private float x;
    public float neckSpeed = -2f;
    private Vector3 neckTurning;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Mouse Y") * neckSpeed;
        transform.Rotate(x, 0, 0, Space.Self);
    }
}
