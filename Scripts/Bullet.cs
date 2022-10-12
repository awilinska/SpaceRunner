using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    private void Update() {
        transform.Translate(transform.right * transform.localScale.x * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Obstacle")) {
            Destroy(gameObject);
        }
    }
}
