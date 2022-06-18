using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    Scene scene;
     public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

     public void Exit()
    {
         Application.Quit();
    }

    public void PauseMenu()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 0f;
    }

     public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OptionMenu()
    {
        SceneManager.LoadScene(5);
    }

     public void LevelTwo()
    {
        SceneManager.LoadScene(2);
    }

    public void LevelThree()
    {
        SceneManager.LoadScene(3);
    }

     public void Resume()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

   
}
