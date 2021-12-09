using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfollow : MonoBehaviour
{  
 

    public Transform player;

    public float shootSpeed ;

    void Update()
    {
        player = GameObject.Find("PlayerModel");
       
        transform.LookAt(player.position);

        transform.Rotate(new Vector3(0, -90, 0), Space.Self);

 
        if (Vector3.Distance(transform.position, player.position) > 1f)

        {
            Debug.Log("I'm hit");


            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));

        }

        

    }

 


}
