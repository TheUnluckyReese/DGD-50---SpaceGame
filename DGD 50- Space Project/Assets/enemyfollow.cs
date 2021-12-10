using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfollow : MonoBehaviour
{  
 

    private Transform player;

    public float speed ;

    public float shotTimer , shotTimeMax , shotTimeMin;

    public GameObject enemBull;
    public float bullSpeed;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {        
        //rotate to look at the player

        transform.LookAt(player.position);

        transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcting the original rotation

        //move towards the player

        if (Vector3.Distance(transform.position, player.position) > 5f)
        {//move if distance from target is greater than 1

            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            Debug.Log("Im close");
        }else
        {
            shotTimer += Time.deltaTime;

            if(shotTimer >= shotTimeMax)
            {
                enemyPewPew();
                shotTimer = shotTimeMin;

            }

           
        }
    }

    void enemyPewPew()
    {
        GameObject bullSpawn = Instantiate(enemBull , transform.position , Quaternion.identity) as GameObject;

        Rigidbody bullSpawnRB = bullSpawn.GetComponent<Rigidbody>();
        enemBull.transform.position = transform.position + Camera.main.transform.forward * 4;

        bullSpawnRB.AddForce(Vector3.forward * bullSpeed);

        Destroy(bullSpawn, 2f);



    }

 


}
