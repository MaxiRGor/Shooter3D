using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookHorizontal : MonoBehaviour
{
    public float sensivityHor = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
        {
            body.freezeRotation = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensivityHor, 0);
    }
}
