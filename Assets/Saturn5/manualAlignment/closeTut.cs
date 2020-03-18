using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeTut : MonoBehaviour {
    public GameObject tutAnim;

	// Use this for initialization
	void Start () {
        StartCoroutine(waitToStopAnim());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator waitToStopAnim()
    {
        yield return new WaitForSeconds(7f);
        tutAnim.SetActive(false);
    }
}
