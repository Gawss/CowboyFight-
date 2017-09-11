using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour {

    [SerializeField]
    private Animator enemyAnimation;
    // Use this for initialization
    void Start () {
        enemyAnimation.SetInteger("enemyAnim", 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (ScneController.globalState == "preFight")
        {
            //Inicia animación
            enemyAnimation.SetInteger("enemyAnim", 1);
        }
    }
}
