using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour {
     
    public void StartGame() {
        SceneManager.LoadScene("Collect em all");
    }

    public void ResetGame() {
        SceneManager.LoadScene("Collect em all");
    }
}
