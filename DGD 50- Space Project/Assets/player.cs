using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
   public Rigidbody rb;

   public int imHit;

   public int pHealth, pHealthMax, pHealthMin;
   public int pAmmo, pAmmoMAX , pAmmoMIN;


   void Start()
   {
       Debug.Log("We are running");
   }
   

   void Update()
   {
       if(pHealthMax == pHealth)
       {
           //speed up if you gained max health
           Debug.Log("FEVERRRR");
       }

       if(Input.GetKeyDown(KeyCode.Space))
       {
           Debug.Log("Pew Pew" );
           pAmmo --;
       }

       if(Input.GetKeyDown(KeyCode.R))
       {
           Debug.Log("Ammo now " + pAmmo);
           pAmmo += pAmmoMAX;
       }

       if(pAmmo <= pAmmoMIN)
       {
           Debug.Log("Please Reload");
       }

       

   }

   void OnCollisionEnter(Collision collision)
   {

       Debug.Log(collision.collider.name);

       if(collision.gameObject.tag == "Asteroid") 
       {
           Debug.Log("Ouch");

           pHealth --;

       }

       if(collision.gameObject.tag == "HealthPack")
       {
           Debug.Log("Eat Up");

           pHealth ++;
       }

       if(collision.gameObject.tag == "bullet ")
       {
           Debug.Log("I've been hit");

           pHealth --;
       }

   }
    
}
