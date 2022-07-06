using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    float speed;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Return))
       rb.AddForce(Vector3.forward*speed)
    }
}
