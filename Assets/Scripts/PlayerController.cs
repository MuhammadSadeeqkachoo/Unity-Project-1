using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private Variables
    private float speed = 5.0f;
    private float turnspeed = 25.0f;
    private float horizontalInput ;
    private float verticalInput;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Getting input from user
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the vehicle forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed*verticalInput);
        //Turn left or right the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);

    }
}
