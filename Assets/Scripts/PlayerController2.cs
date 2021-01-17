using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController2 : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;
    public Text collisioncountText;
    public GameObject ResetButton;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Timer;

    private Rigidbody rb;
    private int count;
    private int collisioncount;


    void Start() {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
        collisioncountText.text = "";
    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("AHorizontal");
        float moveVertical = Input.GetAxis("BVertical");

        //simulate movement of position and direction in 3d environmeny
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        //add movement force
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Pick Up")) {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Player") {
            count = count - 1;
            LosePoints();
            CollisionCountText();
        }
    }

    void CollisionCountText() {
        collisioncount = collisioncount + 1;
        collisioncountText.text = "Player 2 Collision: " + collisioncount.ToString();
    }

    void SetCountText() {
        countText.text = "Player 2 Score: " + count.ToString();
        if (count >= 12) {
            winText.text = "Player 2 Wins";
            ResetButton.SetActive(true);
            Timer.SetActive(false);
            Player1.SetActive(false);
            Player2.SetActive(false);
        }
    }

    void LosePoints() {
        countText.text = "Player 2 Score: " + count.ToString();
        if (count <= 0) {
            count = 0;
            countText.text = "Player 2 Score: " + count.ToString();
        }
    }
}
