// Script for game over canvas

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public void ReturnToMenu() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // Loading Menu scene
    }

    public void NewGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Loading current scene again (new game)
    }
}
