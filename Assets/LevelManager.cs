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

    public void OptionMenu()
    {
        SceneManager.LoadScene(4);
    }

     public void LevelTwo()
    {
        SceneManager.LoadScene(2);
    }

    public void LevelThree()
    {
        SceneManager.LoadScene(3);
    }

   
}
