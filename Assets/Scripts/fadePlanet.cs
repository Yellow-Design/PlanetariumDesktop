using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadePlanet : MonoBehaviour {
	public Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerEnter(Collider col){
		if (col.transform.tag == "show") {
            Debug.Log("HIGHLIGHT");
            anim.SetBool("show", true);
            anim.SetBool("unShow", false);
        }
        /*if (col.transform.tag == "GameController") {
			anim.SetBool ("show", false);
		//anim.SetBool ("fadeOut", true);
			//anim.SetBool ("fadeIn", false);
            Debug.Log("FADE");
        }*/
    }

	public void OnTriggerExit(Collider col){
	/*if (col.transform.tag == "GameController") {
            anim.SetBool("show", false);
            anim.SetBool("unShow", true);
            //anim.SetBool ("fadeOut", false);
            //anim.SetBool ("fadeIn", true);
        }*/
        if (col.transform.tag == "show") {
            anim.SetBool("show", false);
            anim.SetBool("unShow", true);
            //anim.SetBool ("fadeOut", true);
            //anim.SetBool ("fadeIn", false);
        }
    }
}
