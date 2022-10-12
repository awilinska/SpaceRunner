// Script for space ship.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 movement;
    public float moveValueY;
    
    public float speed;

    public float lowerLimit;
    public float upperLimit; // Up and down movement limits

    public float armor = 100; // Total armor 
    public Text armorDisplay;

    public GameObject burst;
    public GameObject gameOver;

    // Update is called once per frame
    void Update()
    {
        armorDisplay.text = ("Armor: " + armor.ToString()); // Displaying armor value on screen

        if (armor <= 0) { // If armor is 0 or lower:
            Instantiate(burst, transform.position, Quaternion.identity); // burst space ship
            gameOver.SetActive(true); // displaying game over canvas
            Destroy(gameObject); 
        }

        transform.position = Vector2.MoveTowards(transform.position, movement, speed * Time.deltaTime); // Horizontal movement

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < upperLimit) {
            movement = new Vector2(transform.position.x, transform.position.y + moveValueY); // Moving up 
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > lowerLimit) {
            movement = new Vector2(transform.position.x, transform.position.y - moveValueY); // Moving down
        }
        
    }
}
