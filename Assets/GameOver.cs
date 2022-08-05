using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TMP_Text score;
    public void gameover(){
    gameObject.SetActive(true);
    score.text = "100 points";
        
   }

   public void Restart(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }

   public void MainMenu(){
    Time.timeScale=1f;
    SceneManager.LoadScene(0);
   }
   
}
