using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamFolower : MonoBehaviour {
    public Transform target;
    public float smoothTime = 3.0f;
    private Vector3 velocity = Vector3.zero;
    private Vector3 targetPos;

	
	void Update ()
    {
        //transform.position = Vector3.SmoothDamp(transform.position, target.position,ref velocity, smoothTime);
	}
}
