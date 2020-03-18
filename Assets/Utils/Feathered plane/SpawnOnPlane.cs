using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpawnOnPlane : MonoBehaviour
{
    public GameObject ToSpawn;
    public string TagToSpawnOn;
    public float yOffset;
    bool spawned = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (!spawned)
        {
            if (Input.touchCount > 0)
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.GetTouch(0).position), out hit))
                    if (hit.collider.tag == TagToSpawnOn)
                        Spawn(hit.point);
        }
    }

    void Spawn(Vector3 point)
    {
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("AR Plane"))
            Destroy(g);
        Destroy(this.GetComponent<ARPlaneManager>());
        GameObject temp = Instantiate(ToSpawn, point + Vector3.up * yOffset, Quaternion.identity);
        temp.transform.forward = new Vector3(Camera.main.transform.forward.x, 0f, Camera.main.transform.forward.z);
        spawned = true;
    }
}
