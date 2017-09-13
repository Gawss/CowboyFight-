using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge : MonoBehaviour {

    private AudioSource challengeToDuel;

    // Use this for initialization
    void Start () {
        challengeToDuel = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void Sound(int soundInd)
    {
        switch (soundInd)
        {
            case 1:
                challengeToDuel.Play();
                break;
        }
    }
}
