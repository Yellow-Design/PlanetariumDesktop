using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {
    GameObject scene;

	// Use this for initialization
	void Start () {
        scene = GameObject.Find("Scene");
        spawnHere();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void spawnHere(){
        scene.transform.position = transform.position;
        scene.transform.rotation = transform.rotation;
    }
}
