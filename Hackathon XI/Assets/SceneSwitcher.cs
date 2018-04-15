using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

    public static int scene = 0;

    // Use this for initialization
    void Start () {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire2"))
        {
            scene++;
            if (scene > SceneManager.sceneCountInBuildSettings) scene = 0;
            SceneManager.LoadScene(scene);
        }
    }
}
