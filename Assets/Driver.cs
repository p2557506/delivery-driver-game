using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    
    //Steer speed given variable so its value can be changed 
    [SerializeField] float steerSpeed = 0.1f;
    
    [SerializeField] float moveSpeed = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Frame rate independent
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        

        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);

        
    }
}
