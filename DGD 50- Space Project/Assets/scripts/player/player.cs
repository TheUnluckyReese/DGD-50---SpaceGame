using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

   //public AudioClip lasers;
   //public AudioClip destroy;
   //public AudioClip hoop;

   private AudioSource playerHear;



   void Update()
   {

    playerHear = GetComponent<AudioSource>();

       bulletText.text = ( "." + pAmmo);
       healthText.text = ( "." +pHealth );

       //healing 
       if(pHealthMax == pHealth)
       {
           //speed up if you gained max health
           Debug.Log("FEVERRRR");
       }

       //speed move

       if(Input.GetKeyDown(KeyCode.S))
       {
           moving.speed --;
       }

       if(Input.GetKeyDown(KeyCode.W))
       {  
           moving.speed ++;
       }     

       if(pHealth <= 0 )
       {
           SceneManager.LoadScene("gameOver");
       }
     


   }

   void OnCollisionEnter(Collision collision)
   {

       if(collision.gameObject.tag == "Asteroid") 
       {
           //Destroy(collision.gameObject);

           pHealth --;
       }

       if(collision.gameObject.tag == "enemBull")
       {
           Debug.Log("I've been hit");

           pHealth --;
       }

       if(collision.gameObject.tag == "Hoop")
       {
           playerHear.PlayOneShot(playerHear.clip);

       }

   }
    
}

