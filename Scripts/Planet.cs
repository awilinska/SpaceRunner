// Script for the planets. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{

    public float planetDamage = 50; // Damage from hitting planet
    public float speed; 
    public GameObject burst;
    public GameObject burstSound;

    private void Update() {
        transform.Translate(Vector2.left * speed * Time.deltaTime); // Moving
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) { // When the planet hits object with tag "Player":
            Instantiate(burstSound, transform.position, Quaternion.identity); // burst sound
            Instantiate(burst, transform.position, Quaternion.identity); // burst animation
            other.GetComponent<Player>().armor -= planetDamage; // damaging player
            Debug.Log(other.GetComponent<Player>().armor);
            Destroy(gameObject); // destroying planet object
        }
    }
}
