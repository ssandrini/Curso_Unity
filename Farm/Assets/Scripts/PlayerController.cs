using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 15.0f;

    public GameObject projectilePrefab;
    
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        var transformWrapper = transform.position; 
        
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transformWrapper.y, transformWrapper.z);
        }
        else if (transform.position.x < - xRange)
        {
            transform.position = new Vector3(-xRange, transformWrapper.y, transformWrapper.z);
        }
        else
        {
            transform.Translate(horizontalInput * Vector3.right * Time.deltaTime * speed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
