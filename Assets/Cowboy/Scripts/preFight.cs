using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preFight : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(ScneController.globalState == "preFight")
        {
            Challenge();
        }
	}
    void Challenge()
    {

    }
}
