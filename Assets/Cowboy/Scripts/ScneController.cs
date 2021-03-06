﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VR;

public class ScneController : MonoBehaviour {

    [SerializeField]
    public GameObject cowboyTitle;
    public GameObject press_toplay_text;
    public GameObject Gun;
    public GameObject enemy;
    private AudioSource startGame;
    public GameObject rotIndic;
    public GameObject rotationTrigger;
    public GameObject rotSensor;
    public GameObject countDown;
    public GameObject camController;
    public GameObject victoryText;
    public GameObject defeatText;
    public GameObject GVrPointer;
    public GameObject targetPointer;

    public GameObject killingSpreeNum;

    public GameObject enemysCapturedNum;
    [SerializeField]
    private Camera camera;

    float timeVar01;
    public static string globalState = "menu";
    public static bool gunSoundState = false;

    Text killSpreeNum;
    int numKills = 0;
    Text enemysCaptured_Num;
    public static int numVictories = 0;

    bool killsCounter = false;

    // Use this for initialization
    void Start()
    {
        timeVar01 = 0;
        startGame = GetComponent<AudioSource>();
        killSpreeNum = killingSpreeNum.GetComponent<Text>();
        enemysCaptured_Num = enemysCapturedNum.GetComponent<Text>();
        ResetplayerPosition();
    }

    // Update is called once per frame
    void Update()
    {
        enemysCaptured_Num.text = numVictories.ToString();
        killSpreeNum.text = numKills.ToString();   
        if (globalState == "menu")
        {
            ResetplayerPosition();
            VRDevice.DisableAutoVRCameraTracking(camera, true);
            targetPointer.SetActive(false);
            GVrPointer.SetActive(true);
            victoryText.SetActive(false);
            defeatText.SetActive(false);
            Gun.SetActive(false);
            rotIndic.SetActive(false);
            rotationTrigger.SetActive(false);
            camController.GetComponent<Animator>().enabled = false;
            cowboyTitle.SetActive(true);

            timeVar01 += Time.deltaTime;
            if (timeVar01 >= 0.4f)
            {
                timeVar01 = 0f;
                if (press_toplay_text.activeSelf == true)
                {
                    press_toplay_text.SetActive(false);
                }
                else
                {
                    press_toplay_text.SetActive(true);
                }
            }

            if (Input.GetButtonDown("Fire1") || OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            {
                TaskOnClick();
            }
        }
        if (globalState == "move")
        {
            VRDevice.DisableAutoVRCameraTracking(camera, false);
            rotIndic.SetActive(true);
            rotationTrigger.SetActive(true);
            rotSensor.SetActive(true);
        }
        if(globalState == "timeToWalk")
        {
            VRDevice.DisableAutoVRCameraTracking(camera, true);
            camController.GetComponent<Animator>().enabled = true;
            rotIndic.SetActive(false);
            rotSensor.SetActive(false);
            rotationTrigger.SetActive(false);
        }
        if(globalState == "countDown")
        {            
            
        }
        if (globalState == "Fighting!!")
        {
            VRDevice.DisableAutoVRCameraTracking(camera, false);
            targetPointer.SetActive(true);
            enemy.GetComponent<CapsuleCollider>().enabled = true;
            GVrPointer.SetActive(false);
            camController.GetComponent<Animator>().enabled = false;
            Gun.SetActive(true);
        }
        if (globalState == "victory")
        {
            enemy.GetComponent<CapsuleCollider>().enabled = false;
            victoryText.SetActive(true);

            numKills = numKills + Random.Range(0,10);
            if (killsCounter == false)
            {
                numVictories = numVictories + 1;
                killsCounter = true;
            }
        }
        if(globalState == "defeat")
        {
            targetPointer.SetActive(false);
            defeatText.SetActive(true);
            numKills = 0;
            numVictories = 0;
        }
        if(globalState == "battleEnd")
        {
            Gun.SetActive(false);
            cowboyTitle.SetActive(true);
            enemy.SetActive(true);
            globalState = "menu";
            killsCounter = false;
        }
    }

    void TaskOnClick()
    {
        cowboyTitle.SetActive(false);
        //press_toplay.SetActive(false);
        press_toplay_text.SetActive(false);
        startGame.Play();
        globalState = "preFight";
    }
    void ResetplayerPosition()
    {
        camController.transform.localPosition = new Vector3(0, 0, 0);
        camController.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }
}

