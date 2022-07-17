using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
   public float speed = 7;

    private Rigidbody rb;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //Allows player to move horizontally
        float moveH=Input.GetAxis("Horizontal");
        
        //Allows player to move vertically
        float moveV=Input.GetAxis("Vertical");

        Vector3 movement=new Vector3(moveH,0.0f,moveV);

        rb.AddForce(movement*speed);
    }
}