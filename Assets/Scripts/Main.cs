using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Main : MonoBehaviour {

    bool inited = false;
    bool switching = false;

    // Use this for initialization
    void Start () {
        XRSettings.enabled = false;
    }

	IEnumerator ToggleVR()
	{
        switching = true;

		if (!inited ) {
            inited = true;
			XRSettings.LoadDeviceByName( "cardboard");
        }
        yield return null;
        XRSettings.enabled = !XRSettings.enabled;
        yield return null;
        switching = false;
    }
	
	// Update is called once per frame
	void Update () {
        foreach (var t in Input.touches){
            
            if ( t.phase == TouchPhase.Began && !switching){
                Debug.Log("touch");
                StartCoroutine(ToggleVR());
            }
        }
	}
}
