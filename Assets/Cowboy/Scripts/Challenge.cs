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
                Debug.Log("I challenge u to a Duel!");
                challengeToDuel.Play();
                break;
        }
    }
    public void enemyVictory(int enemyVic)
    {
        switch (enemyVic)
        {
            case 1:
                Debug.Log("Enemy Wins");
                ScneController.globalState = "defeat";
                break;
        }
    }
}
