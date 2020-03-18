using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SetCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        VideoPlayer vp = this.GetComponent<VideoPlayer>();
        vp.renderMode = VideoRenderMode.CameraNearPlane;
        vp.targetCamera = Camera.main;
        vp.targetCameraAlpha = 0.6f;
    }

    
}
