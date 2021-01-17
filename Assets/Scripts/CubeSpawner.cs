using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour
{

    public GameObject cube;
    public float spawn_position;
    public float timer = 10.0f;

    void SpawnCube() {
        GameObject clone = Instantiate(cube, transform.position, transform.rotation) as GameObject;

    }
    void Start() {
        timer = Time.time;
    }

    void Update() {
        if (Time.time - timer > 10) {
            SpawnCube();
            timer = Time.time;
        }
    }
}