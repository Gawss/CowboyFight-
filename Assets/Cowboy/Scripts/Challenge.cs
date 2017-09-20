using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge : MonoBehaviour {

    private AudioSource challengeToDuel;
    [SerializeField] private AudioSource gunShot;

    // Use this for initialization
    void Start () {
        challengeToDuel = GetComponent<AudioSource>();
        gunShot = GetComponent<AudioSource>();
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
    public void enemyVictory(int enemyVic)
    {
        switch (enemyVic)
        {
            case 1:
                ScneController.globalState = "defeat";
                break;
        }
    }
    public void gunSound(int gunsound)
    {
        switch (gunsound)
        {
            case 1:
                gunShot.Play();
                break;
        }
    }
}
