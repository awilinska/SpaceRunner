// Script for the space station.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour
{

    public float speed;
    public GameObject stationSound;

    private void Update() {
        transform.Translate(Vector2.left * speed * Time.deltaTime); // Movement
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) { // If collide with the object tagged as "Player:
            Instantiate(stationSound, transform.position, Quaternion.identity); // make station sound
            other.GetComponent<Player>().armor = 100; // reset space ship armor to 100
            other.GetComponent<Shooting>().bulletCount = 3; // reset number of bullets to 3
            Debug.Log(other.GetComponent<Player>().armor);
        }
    }
}
