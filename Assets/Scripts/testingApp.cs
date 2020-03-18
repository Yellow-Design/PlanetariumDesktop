using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testingApp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void openGlobe() {
        Application.LoadLevel("Moon_globe");
    }

    public void openSurface()
    {
        Application.LoadLevel("surface4");
    }
}
