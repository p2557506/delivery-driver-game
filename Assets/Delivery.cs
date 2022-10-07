using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool isPickedUp;
    [SerializeField] float timeUntilDestroy = 1f;

    void OnCollisionEnter2D(Collision2D other) 
    {
        
        Debug.Log("Ya hitemup");
        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        
        //If package is triggered print pickup
        if(other.tag == "Package" && isPickedUp == false){

        Debug.Log("Package picked up");
        
        if(isPickedUp == false){
        Destroy(other.gameObject,timeUntilDestroy);

        }
        isPickedUp = true;
        }

        if(other.tag == "Customer" && isPickedUp == true){
            Debug.Log("Package delivered");
            isPickedUp = false;
        }
    }

}
