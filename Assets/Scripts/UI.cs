using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI : MonoBehaviour {
    public GameObject launchButton;
    public GameObject fact1;
    public GameObject fact2;
    public GameObject fact3;
    public GameObject fact4;
    public Animator rocketAnim;
    Animator anim;
    public GameObject audio;

    //public Text popUpText;
    public string[] facts;
    public int factNumber = 0;
    int numberOfChecks = 5;

    bool firstCheckDone = false;
    public bool track;
    public static bool launched;
   
    // Use this for initialization
    void Start () {
        anim = fact1.GetComponentInParent<Animator>();

        //popUpText.text = facts[0].ToString();
        launchButton.SetActive(false);
        fact1.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
//        if(track){
//            GenerateImageAnchor.tracked = true;
//        }else{
//            GenerateImageAnchor.tracked = false;
//        }

        startChecklist();
        enableLaunchSequence();
	}

    public void Acknowledge(){
        //PLAY TRANSITION ANIMATION//
        if (factNumber == 1){
            anim.SetBool("secondAcknowledged", true);
        }
        if (factNumber == 2){
            anim.SetBool("thirdAcknowledged", true);
        }
        if (factNumber == 3){
            anim.SetBool("fourthAcknowledged", true);
        }
        if(factNumber == 4)
        {
            anim.SetBool("show5th", true);
        }

        factNumber++;
       //popUpText.text = facts[factNumber].ToString();
        //fact1.SetActive(false);
        //StartCoroutine(wait2Seconds());
    }

    IEnumerator wait2Seconds(){
        yield return new WaitForSeconds(2);
        //PLAY TRANSITION ANIMATION//
        fact1.SetActive(true);
        anim.SetBool("firstAcknowledged", true);
        factNumber++;
    }

    void startChecklist(){
//        if(GenerateImageAnchor.tracked && !firstCheckDone){
//            firstCheckDone = true;
//            StartCoroutine(wait2Seconds());
//        }   
    }

    void enableLaunchSequence(){
        if(factNumber >= numberOfChecks && !launched){

            launchButton.SetActive(true);
            fact1.SetActive(false);
        }
    }

    public void startLaunchSequence(){
        launchButton.SetActive(false);
        rocketAnim.SetBool("launch", true);
        audio.SetActive(true);
        launched = true;
        heliBehaviour.flyAway = true;
        heliBehaviour.moveTo1 = true;
        heliBehaviour.moveTo2 = false;
        heliBehaviour.moveTo3 = false;
        heliBehaviour.moveTo4 = false;
    }
}
