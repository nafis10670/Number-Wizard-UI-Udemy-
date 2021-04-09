using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ThatsIt()
    {
        SceneManager.LoadScene(2);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
