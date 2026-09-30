using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TransformTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position = transform.position + new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-0.1f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, 1.0f, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, -1.0f, 0);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position = transform.position + new Vector3(0.1f, 0.1f, 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(-0.1f, -0.1f, -0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space key was pressed");
        }
    }
}
