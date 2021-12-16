using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBull : MonoBehaviour
{
    private gameManager scores;

    void Start()
    {
        scores = GameObject.FindGameObjectWithTag("Manager").GetComponent<gameManager>();
    }


    void OnCollisionEnter(Collision collision)
    {        
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);

            Destroy(gameObject);          

            

            //IncreaseScores();
            scores.gameScore += 1000;
        }
    }
    


}
