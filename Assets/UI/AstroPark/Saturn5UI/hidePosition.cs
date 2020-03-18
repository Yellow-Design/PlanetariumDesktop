using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidePosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(hideAnim());	
	}

    IEnumerator hideAnim() {
        yield return new WaitForSeconds(4f);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
