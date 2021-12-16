using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class player : MonoBehaviour
{
  //public Rigidbody rb;

  public TextMeshProUGUI bulletText;
  public TextMeshProUGUI healthText;

   public int imHit;
   public Movement moving;
  
   public int pHealth;
   int pHealthMax, pHealthMin;
   int pAmmo, pAmmoMAX , pAmmoMIN;



   void Update()
   {
       bulletText.text = ( "." + pAmmo);
       healthText.text = ( "." +pHealth );

       //healing 
       if(pHealthMax == pHealth)
       {
           //speed up if you gained max health
           Debug.Log("FEVERRRR");
       }

       //speed move

       if(Input.GetKeyDown(KeyCode.W))
       {
           moving.speed --;
       }

       if(Input.GetKeyDown(KeyCode.S))
       {  
           moving.speed ++;
       }     
     

       //shooting

       if(Input.GetKeyDown(KeyCode.Space))
       {
           //Debug.Log("Pew Pew" );
           pAmmo --;
       }

       if(Input.GetKeyDown(KeyCode.R))
       {
           Debug.Log("Ammo now " + pAmmo);
           pAmmo += pAmmoMAX;
       }

       if(pAmmo <= pAmmoMIN)
       {
          
       }

       

       
       

   }

   void OnCollisionEnter(Collision collision)
   {

       Debug.Log(collision.collider.name);

       if(collision.gameObject.tag == "Asteroid") 
       {
           //Destroy(collision.gameObject);

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

 //speed 
       /*
       if(Input.GetKeyDown(KeyCode.A))
       {
           moving.speed --;
       }

       if(Input.GetKeyDown(KeyCode.D))
       {  
           moving.speed ++;
       }

       */ //public Movement moving;
