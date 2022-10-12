// Script for counting points. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;

    void Update() {
        scoreDisplay.text = ("Score: " + score.ToString()); // Displaying current score on the screen
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Obstacle")) { // If the object tagged "Obstacle" colliding with score coutner one point is adding.
            score++;
            Debug.Log(score);
        }
    }
}
