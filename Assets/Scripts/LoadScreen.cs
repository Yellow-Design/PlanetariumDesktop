using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScreen : MonoBehaviour
{
    public List<MonoBehaviour> ARScripts;
    // Start is called before the first frame update
    void Start()
    {
        foreach (MonoBehaviour m in ARScripts)
            m.enabled = false;
        StartCoroutine(startAR());
    }

    IEnumerator startAR()
    {
        yield return new WaitForSeconds(3f);
        foreach (MonoBehaviour m in ARScripts)
            m.enabled = true;
    }
}
