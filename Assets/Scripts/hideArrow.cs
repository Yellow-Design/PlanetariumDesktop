using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideArrow : MonoBehaviour {
    public GameObject arrow;

	// Use this for initialization
	void Start () {
        StartCoroutine(waitToHideArrow());
	}

    IEnumerator waitToHideArrow() {
        yield return new WaitForSeconds(3f);
        gameObject.SetActive(false);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
