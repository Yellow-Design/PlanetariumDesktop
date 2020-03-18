using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crewSelection : MonoBehaviour {
    public static bool fullUnlocked = false;

    public static int numberOfAdults = 0;
    public int Adults = 0;
    public static int numberOfChildren = 0;
    public int Children = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addAdultCrew(){
        numberOfAdults++;
        Adults++;
    }

    public void addChildCrew(){
        numberOfChildren++;
        Children++;
    }
}