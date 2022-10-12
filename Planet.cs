using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{

    public float planetDamage = 50;
    public float speed;
    public GameObject burst;
    public GameObject burstSound;

    private void Update() {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            Instantiate(burstSound, transform.position, Quaternion.identity);
            Instantiate(burst, transform.position, Quaternion.identity);
            other.GetComponent<Player>().armor -= planetDamage;
            Debug.Log(other.GetComponent<Player>().armor);
            Destroy(gameObject);
        }
    }
}
