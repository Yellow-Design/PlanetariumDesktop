using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anchorInitialise : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(enableAnchor());
	}

    IEnumerator enableAnchor() {
        yield return new WaitForSeconds(3f);
//        GenerateImageAnchor script = gameObject.GetComponent<GenerateImageAnchor>();
//        script.enabled = true;
        //gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
