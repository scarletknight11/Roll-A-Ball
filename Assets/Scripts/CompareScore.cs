using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompareScore : MonoBehaviour {

    public float timeStart = 120;
    public Text textBox;
    public Text countText;
    public Text countText2;
    public Text winText;
    private int count1;
    private int count2;


    // Start is called before the first frame update
    void Start() {
        count1 = 0;
        count2 = 0;
        winText.text = "";
    }

 

    void Update() {
        if(timeStart <= 0 && count1 > count2) {
            winText.text = "Player 1 Wins";
        } else if (timeStart <= 0 &&  count2 > count1) {
            winText.text = "Player 2 Wins";
        }

    }
}
