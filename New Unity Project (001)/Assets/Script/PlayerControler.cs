using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveSpeed = 5.0f;
    private float turnSpeed =23.0f;
    private float HorizontalInput;
    private float vertcalInput;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
//wre player input
        vertcalInput = Input.GetAxis("Vertical");
        HorizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * vertcalInput * moveSpeed);
        transform.Rotate(Vector3.up * Time.deltaTime * HorizontalInput * turnSpeed);


    }
}
