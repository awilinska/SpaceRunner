// Script for shooting bullets by player. 

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform gun;
    public int bulletCount = 3; // Number of available bullets
    public Text bulletsDisplay;
    public GameObject shotSound;
    public GameObject emptySound;

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) { // Shooting by pressing space
            Shoot();
            bulletCount -= 1; // Substract one bullet after shoot
        }
        
        if (bulletCount >= 0) {
            bulletsDisplay.text = ("Bullets: " + bulletCount.ToString()); // Diplaying number of bullets
        }
        else {
            bulletsDisplay.text = ("Bullets: 0"); // Diplay bullets when the number is <= 0
        }
        
    }

    void Shoot() {
        if (bulletCount <= 0) {
            Instantiate(emptySound, transform.position, Quaternion.identity); // Shooting sound when player have no bullets left
            return;
        }

        Instantiate(shotSound, transform.position, Quaternion.identity); // Shooting sound 
        GameObject si = Instantiate(bullet, gun); // Creating new bullet
        si.transform.parent = null;
    }
}
