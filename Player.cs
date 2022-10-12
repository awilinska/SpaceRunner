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
    public float upperLimit;

    public float armor = 100;
    public Text armorDisplay;

    public GameObject burst;
    public GameObject gameOver;

    // Update is called once per frame
    void Update()
    {
        armorDisplay.text = ("Armor: " + armor.ToString());

        if (armor <= 0) {
            Instantiate(burst, transform.position, Quaternion.identity);
            gameOver.SetActive(true);
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, movement, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < upperLimit) {
            movement = new Vector2(transform.position.x, transform.position.y + moveValueY);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > lowerLimit) {
            movement = new Vector2(transform.position.x, transform.position.y - moveValueY);
        }
        
    }
}
