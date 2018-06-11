using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    Quaternion r;

    // Use this for initialization
    void Start () {
        r = Quaternion.Euler(1.5f, 2.5f, 3.5f);
    }
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.localRotation *= r;
    }
}
