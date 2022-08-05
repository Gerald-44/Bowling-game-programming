
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    
       [SerializeField] 
       private float spinSpeed =2f;
    

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0f, spinSpeed, 0f ,Space.World); 
    }

    
}
