using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    
    //Steer speed given variable so its value can be changed 
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.01f;
    [SerializeField] float slowerSpeed = 5f;
    [SerializeField] float boostSpeed = 20f;

    float moveAmount;
    float steerAmount;
    

    // Update is called once per frame
    void Update()
    {
        //Frame rate independent
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        

        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);



        
    }
    void OnTriggerEnter2D(Collider2D other) {

        if(other.tag == "Booster")
        {
            Debug.Log("zoomin");
            moveSpeed = boostSpeed;
        }
            
        }
    void OnCollisionEnter2D(Collision2D other)
     {

        moveSpeed = slowerSpeed;
 
     }
}
