using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float timeStart = 120;
    public GameObject cubes;
    public GameObject player1;
    public GameObject player2;
    public Text textBox;
    public Text message;
 

    public GameObject ResetButton;

 


    // Use this for initialization
    void Start() {
        textBox.text = timeStart.ToString();
        message.text = "";
 
    }

    // Update is called once per frame
    void Update() {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();
        if (timeStart <= 10) {
            message.text = "Times almost up";
        }

        if (timeStart <= 0) {
            message.text = "Times up";
            timeStart = 0;
            cubes.SetActive(false);
            player1.SetActive(false);
            player2.SetActive(false);
            ResetButton.SetActive(true);
        }
    }
}
