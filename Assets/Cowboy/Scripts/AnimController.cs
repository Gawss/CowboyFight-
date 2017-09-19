﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour {

    [SerializeField]
    private Animator enemyAnimation;
    [SerializeField]
    private Animator countDown;
    [SerializeField]
    private Animator camController;
    [SerializeField]
    private Animator fadeOut;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if(ScneController.globalState == "menu")
        {
            enemyAnimation.SetInteger("enemyAnim", 0);
            fadeOut.SetInteger("FadeOut", 0);
        }
        if (ScneController.globalState == "preFight")
        {
            enemyAnimation.SetInteger("enemyAnim", 1);
        }
        if (ScneController.globalState == "timeToWalk")
        {
            enemyAnimation.SetInteger("enemyAnim", 2);
        }
        if (ScneController.globalState == "countDown")
        {
            camController.SetInteger("camController", 0);
        }
        if (ScneController.globalState == "countDown")
        {
            countDown.SetInteger("countDown", 1);
        }
        if (ScneController.globalState == "Fighting!!")
        {
            enemyAnimation.SetInteger("enemyAnim", 3);
            camController.SetInteger("camController", 1);
            countDown.SetInteger("countDown", 0);
        }
        if(ScneController.globalState == "shooting")
        {
            enemyAnimation.SetInteger("enemyAnim", 4);
        }
        if (ScneController.globalState == "enemyIsDead")
        {
            enemyAnimation.SetInteger("enemyAnim", 5);
        }
        if (ScneController.globalState == "victory")
        {
            enemyAnimation.SetInteger("enemyAnim", 0);
            fadeOut.SetInteger("FadeOut", 1);
        }
        if (ScneController.globalState == "defeat")
        {
            fadeOut.SetInteger("FadeOut", 1);
        }

    }
}
