using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
    }
}
