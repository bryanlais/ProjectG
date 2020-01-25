using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public void startGame()
    {
        Debug.Log("Started the game!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitGame()
    {
        Debug.Log("Quit the game!");
        Application.Quit();
    }

    public void instructions()
    {
        Debug.Log("Instructions!");
    }
}
