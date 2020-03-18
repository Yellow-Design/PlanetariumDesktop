using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARTrackedImageManager))]
public class SpawnAstroparkPrefabs : MonoBehaviour
{
    ARTrackedImageManager ImageManager;

    public GameObject SolarSystem;
    public GameObject InfinityA;
    public GameObject InfinityB;
    public GameObject Hypercube;
    public GameObject SaturnV;

    bool click = false;

    // Start is called before the first frame update
    void Start()
    {
        ImageManager = this.GetComponent<ARTrackedImageManager>();
        ImageManager.trackedImagesChanged += ImageManager_trackedImagesChanged;
    }

    private void ImageManager_trackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {

        //Debug.Log("IMAGE CHANGED");
        foreach (var trackedImage in eventArgs.added)
        {
            Debug.Log(trackedImage.referenceImage.name);
            switch (trackedImage.referenceImage.name)
            {
                case "Hill A":
                    Instantiate(InfinityA, trackedImage.transform);
                    break;
                case "Hill B":
                    Instantiate(InfinityB, trackedImage.transform);
                    break;
                case "Hypercube":
                    Instantiate(Hypercube, trackedImage.transform);
                    break;
                case "Saturn V":
                    Instantiate(SaturnV, trackedImage.transform);
                    break;
                case "Solar System":
                    Instantiate(SolarSystem, trackedImage.transform);
                    break;
            }
        }
    }
}
