using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;
    

    // Update is called once per frame
    void Update()
    {
        calculateMovement();
    }


    void calculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Vector3 newDirection = new Vector3(horizontalInput, verticalInput, 0f);
        //transform.Translate(newDirection * _speed * Time.deltaTime);

        Vector3 move = transform.forward * verticalInput + transform.right * horizontalInput;
        transform.Translate(_speed * Time.deltaTime * move);
    }
    
}