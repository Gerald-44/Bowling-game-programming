using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgame : MonoBehaviour
{

    //public GameOver gameOver;
    public LevelManager levelManager;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        //gameOver.gameover();
        levelManager.LevelTwo();
    }
}

