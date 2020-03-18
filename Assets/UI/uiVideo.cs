using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine;

public class uiVideo : MonoBehaviour {
    public RawImage rawImg;
    public VideoPlayer player;
    public AudioSource audioSource;
    public GameObject canvas;

	// Use this for initialization
	void Start () {
	}

    IEnumerator playVideo(){
        player.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while(!player.isPrepared){
            yield return waitForSeconds;
            break;
        }

        rawImg.texture = player.texture;
        player.Play();
        audioSource.Play();
    }
	
	// Update is called once per frame
	void Update () {
       /* if(script.vidPlaying){
            Debug.Log("PLAY");
            StartCoroutine(playVideo());
        }else if(!script.vidPlaying) {
            StopCoroutine(playVideo());
            player.Stop();
        }*/
	}
}
