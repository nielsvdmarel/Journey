using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float playerSpeed;
    public float JumpHeight;

    void Start ()
    {
		
	}
	
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position -= transform.forward * Time.deltaTime * playerSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * Time.deltaTime * playerSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= transform.right * Time.deltaTime * playerSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * Time.deltaTime * playerSpeed;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up * Time.deltaTime * JumpHeight;
        }
    }
}
