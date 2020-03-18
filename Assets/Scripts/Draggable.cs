using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Draggable : MonoBehaviour {
	public Slider solarTimeline;
	public Transform solarSystem;

	void Start(){
		solarTimeline.onValueChanged.AddListener (delegate {ValueChangeCheck(); });
	}

	public void ValueChangeCheck(){
		//Debug.Log ("MOVE");
	}

	// Update is called once per frame
	void Update () {
        if(this.transform.name == "solarSystem") {
            solarSystem.localPosition = new Vector3(solarSystem.transform.localPosition.x, solarSystem.transform.localPosition.y, solarTimeline.value);
        }else if (this.transform.name == "IH2") {
            solarSystem.localPosition = new Vector3(solarTimeline.value, solarSystem.transform.localPosition.y, solarSystem.transform.localPosition.z);
        }
    }
}
