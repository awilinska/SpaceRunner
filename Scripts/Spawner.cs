using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] patterns;

    private float spawnTime;
    public float startSpawnTime;
    public float speedUp;
    public float maxSpeed = 0.7f;

    private void Update()
    {
        if (spawnTime <= 0) {
            int rand = Random.Range(0, patterns.Length);
            Instantiate(patterns[rand], transform.position, Quaternion.identity);
            spawnTime = startSpawnTime;
            if (startSpawnTime > maxSpeed) {
                startSpawnTime -= speedUp;
            }
        }
        else {
            spawnTime -= Time.deltaTime;
        }
        
    }
}
