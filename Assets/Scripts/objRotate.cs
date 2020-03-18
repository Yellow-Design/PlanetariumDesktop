using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objRotate : MonoBehaviour {
    public float rotSpeed;
    public static bool dragged = false;

	// Use this for initialization
	void Start () {
		
	}

	private void OnMouseDrag(){
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        //float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -rotX);
        dragged = true;
        //transform.RotateAround(Vector3.right, rotY);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
