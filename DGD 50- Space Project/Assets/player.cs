using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
   public Rigidbody rb;

   public int imHit;

   public int pHealth, pHealthMax, pHealthMin;
   public int pAmmo;

   

   void OnCollisionEnter(Collision collision)
   {

       Debug.Log(collision.collider.name);

       if(collision.gameObject.tag == "Asteroid") 
       {
           Debug.Log("Ouch");
       }
   }
    
}
