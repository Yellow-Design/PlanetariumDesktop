using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trhusterControl : MonoBehaviour {
    public GameObject smokeTrail1;
    public ParticleSystem[] firstEngines;
    public GameObject smokeTrail2;
    public ParticleSystem smokeWall;    

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	public void Launch ()
    {
        StartCoroutine(waitToLaunch());
        StartCoroutine(firstSeparation());
    }

    IEnumerator waitToLaunch(){
        yield return new WaitForSeconds(20f);
        smokeTrail1.SetActive(true);
        yield return new WaitForSeconds(7f);
        smokeWall.Stop();
    }

    IEnumerator firstSeparation(){
        yield return new WaitForSeconds(47f);
        firstEngines[0].Stop();
        firstEngines[1].Stop();
        firstEngines[2].Stop();
        firstEngines[3].Stop();
        firstEngines[4].Stop();
        yield return new WaitForSeconds(4f);
        smokeTrail2.SetActive(true);

    }
}
