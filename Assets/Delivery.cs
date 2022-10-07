using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool packagePickedUp;
    [SerializeField] float timeUntilDestroy = 1f;

    [SerializeField] Color32 packagePickedUpColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);

    SpriteRenderer theSR;

    void Start() 
    {

        theSR = GetComponent<SpriteRenderer>();

        
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        
        Debug.Log("Ya hitemup");
        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        
        //If package is triggered print pickup
        if(other.tag == "Package" && !packagePickedUp){

        Debug.Log("Package picked up");
        //Placed above destroy so that other packages can not be picked up
        packagePickedUp = true;
        theSR.color = packagePickedUpColor;
        Destroy(other.gameObject,timeUntilDestroy);
        
        }

        if(other.tag == "Customer" && packagePickedUp == true){
            Debug.Log("Package delivered");
            packagePickedUp = false;
            theSR.color = noPackageColor;
        }
    }

}
