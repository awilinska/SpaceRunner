// Script for the bullets shooting by space ship. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    private void Update() {
        transform.Translate(transform.right * transform.localScale.x * speed * Time.deltaTime); // Moving
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Obstacle")) {
            Destroy(gameObject); // Bullet will be destroyed after hitting object tagged as "Obstacle"
        }
    }
}
