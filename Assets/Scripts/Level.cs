using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{

    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    // needs to be changed if more levels added
    public void LoadMainScene()
    {
        SceneManager.LoadScene("Main Scene");
    }

    // needs to be changed if more levels added
    public void LoadGameOver()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
