using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
  
    void Awake() {
        if(Instance == null){
            Instance =this;
            DontDestroyOnLoad(Instance);
        }
        else{
            Destroy(Instance);
        }
    }

   
}
