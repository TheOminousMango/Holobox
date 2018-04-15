using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    Animator Anim;
    Rigidbody rb;
    float walkTrig = 0.005f;
	// Use this for initialization
	void Start () {
        Anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = transform.forward * Input.GetAxis("Horizontal");
        //transform.Translate(Input.GetAxis("Vertical") * 0.1f, 0, Input.GetAxis("Horizontal") * 0.1f);
        transform.Rotate(0, Input.GetAxis("Vertical"), 0);
        Anim.SetBool("Fly", Input.GetButton("Fire1"));
        Anim.SetBool("Walk", (Input.GetAxis("Vertical") != 0f || Input.GetAxis("Horizontal") != 0f));
    }
}
