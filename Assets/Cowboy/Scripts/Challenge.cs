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
        if(ScneController.globalState == "preFight")
        {
            challengeToDuel.Play();
            Debug.Log("TE RETO A UN DUELO!");
            //Inicia animación
        }
	}
}
