using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {


    // Update is called once per frame
    void Update() {

        //secondsBetweenSpawning = (maxSecondsBetweenSpawning);
        //Update rotation x,y,z axis frames per second during gameplay
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
