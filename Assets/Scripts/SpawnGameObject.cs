using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGameObject : MonoBehaviour {

    public float secondsBetweenSpawning = 0.1f;
    public float xMinRange = -12.0f;
    public float xMaxRange = 12.0f;
    public float yMinRange = -0.792f;
    public float yMaxRange = -.4f;
    public float zMinRange = -16.0f;
    public float zMaxRange = -2.0f;
    public GameObject[] SpawnObjects;
    public float nextSpawnTime = 10.0f;



    // Start is called before the first frame update
    void Start() {
        nextSpawnTime = Time.time;
    }

    // Update is called once per frame
    void Update() {
        if (Time.time - nextSpawnTime > 10) {
            SpawnCube();
            nextSpawnTime = Time.time;
        }
    }

    void SpawnCube() {

        Vector3 SpawnPosition;

        SpawnPosition.x = Random.Range(xMinRange, xMaxRange);
        SpawnPosition.y = Random.Range(yMinRange, yMaxRange);
        SpawnPosition.z = Random.Range(zMinRange, zMaxRange);

        int ObjectToSpawn = Random.Range(0, SpawnObjects.Length);

        GameObject SpawnedObject = Instantiate(SpawnObjects[ObjectToSpawn], SpawnPosition, transform.rotation) as GameObject;

        SpawnedObject.transform.parent = gameObject.transform;
    }
}
