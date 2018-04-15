using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheForce : MonoBehaviour {
    public Texture[] frames;
    public float fps = 60;
    Material material;
    int frame = 0;
    int index = 0;
	// Use this for initialization
	void Start () {
        material = GetComponent<Renderer>().material;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        frame++;
        if(frame > fps) { frame = 0; index++; if (index > frames.Length - 1) index = 0;  }
        material.mainTexture = frames[index];
    }
}
