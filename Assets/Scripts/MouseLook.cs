using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float turnSpeed = 2.0f;
    private float x = 0.0f, y = 0.0f;
    public bool closed = true;
    private void Start()
    {
        transform.eulerAngles = new Vector3(0, 0, 0);
        Invoke(nameof(OpenIt), 0.5f);
    }
    void OpenIt()
    {
        closed = false;
    }
    void Update()
    {
        if (closed == false)
        {
            x += turnSpeed * Input.GetAxis("Mouse X");
            y -= turnSpeed * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(y, x, 0.0f);
        }
    }

}
