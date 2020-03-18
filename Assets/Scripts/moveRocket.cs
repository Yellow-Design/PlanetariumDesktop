using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class moveRocket : MonoBehaviour {
    public Transform rocket;
    public GameObject hyperCubeGraphic;
    //public bool moveOptionsOpen = false;
    public GameObject options;

   //public Image image;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    /*public void openMovementOptions()
    {
        if (!moveOptionsOpen) {
            var tempColour = image.color;
            tempColour.a = 1f;
            image.color = tempColour;
            moveOptionsOpen = true;
            options.SetActive(true);
        }else {
            var tempColour = image.color;
            tempColour.a = .5f;
            image.color = tempColour;
            moveOptionsOpen = false;
            options.SetActive(false);
        }
    }*/

    public void moveRight()
    {
        Vector3.Lerp(rocket.transform.localPosition, rocket.transform.localPosition += new Vector3(1f, 0, 0), 2f);
    }

    public void moveLeft()
    {
        Vector3.Lerp(rocket.transform.localPosition, rocket.transform.localPosition += new Vector3(-1f, 0, 0), 2f);
    }

    public void lowerRocket()
    {
        Vector3.Lerp(rocket.transform.position, rocket.transform.position += new Vector3(0, -1f, 0f), 2f);
    }

    public void raiseRocket()
    {
        Vector3.Lerp(rocket.transform.position, rocket.transform.position += new Vector3(0, 1f, 0f), 2f);
    }

    public void confirm()
    {
        options.SetActive(false);
        hyperCubeGraphic.SetActive(false);
    }
}
