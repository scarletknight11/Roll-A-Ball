using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;


    private Vector3 offset;

    // Start is called before the first frame update
    void Start() {
        //calculate overall offset between camera & player
        offset = transform.position - player.transform.position;
    }

    // run after all items have been proccessed per frame per seconds
    void LateUpdate() {
        //every frames per second during gameplay calculate player position accroding to camera view of position
        transform.position = player.transform.position + offset;
    }
}
