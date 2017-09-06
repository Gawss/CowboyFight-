using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuScene : MonoBehaviour {

    [SerializeField]
    public GameObject cowboyTitle;
    public GameObject press_toplay;
    public GameObject press_toplay_text;
    public Button pressToPlay;
    public GameObject Gun;
    public GameObject target;

    float timeVar01;
    string globalState = "menu";
    // Use this for initialization
    void Start ()
    { 
        Gun.SetActive(false);
        target.SetActive(false);
        Button btn = pressToPlay.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        timeVar01 = 0;
    }

    // Update is called once per frame
    void Update () {
        if(globalState == "menu")
        {
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
        }
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        cowboyTitle.SetActive(false);
        press_toplay.SetActive(false);
        press_toplay_text.SetActive(false);
        Gun.SetActive(true);
        target.SetActive(true);
        globalState = "playing";
    }
}
