using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour
{

    public float speed;
    public GameObject stationSound;

    private void Update() {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            Instantiate(stationSound, transform.position, Quaternion.identity);
            other.GetComponent<Player>().armor = 100;
            other.GetComponent<Shooting>().bulletCount = 3;
            Debug.Log(other.GetComponent<Player>().armor);
        }
    }
}
