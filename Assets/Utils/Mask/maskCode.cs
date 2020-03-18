using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maskCode : MonoBehaviour {
    Material Material;

	// Use this for initialization
	void Start () {
        Material = gameObject.GetComponent<Renderer>().material;
        Material.renderQueue = 2002;
	}
	
	// Update is called once per frame
	void Update () {
        
    }
}
