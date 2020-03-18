using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ratingFeedback : MonoBehaviour {
    public GameObject ratingWindow;
    public Image stars;
    public Sprite[] ratings;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void send() {
        // SEND RATING //
    }

    public void skip() {
        ratingWindow.SetActive(false);
    }

    public void oneStar(){
        stars.sprite = ratings[0];
    }

    public void twoStar()
    {
        stars.sprite = ratings[1];
        // SEND RATING //
    }

    public void threeStar()
    {
        stars.sprite = ratings[2];
        // SEND RATING //
    }

    public void fourStar()
    {
        stars.sprite = ratings[3];
        // SEND RATING //
    }

    public void fiveStar()
    {
        stars.sprite = ratings[4];
        // SEND RATING //
    }
}
