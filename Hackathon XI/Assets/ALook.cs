using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALook : MonoBehaviour {
    public Transform cam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(cam);
	}
}
