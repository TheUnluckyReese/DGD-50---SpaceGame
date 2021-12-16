using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    int asteroidHealth = 5;
    

    public Vector3 spaceMin;
    public Vector3 spaceMax;

    public GameObject enemy;
    public float  enemSpawnTime   =  1 , enemMaxTime = 10 , enemMinTime  = 0;
    bool spawnEnem;
    float bullSpeed;

    float xAxis, yAxis, zAxis;

    Vector3 randomPos;

    bool isHit;

    public void Start()
    {
        setRange();
    }

    void Update()
    {
        xAxis = UnityEngine.Random.Range(spaceMin.x , spaceMax.x);

        yAxis = UnityEngine.Random.Range(spaceMin.y , spaceMax.y);

        zAxis = UnityEngine.Random.Range(spaceMin.z , spaceMax.z);

        randomPos = new Vector3(xAxis , yAxis, zAxis);
 

       //instantiate enemies 

       enemSpawnTime += Time.deltaTime ;

       if(enemSpawnTime >= enemMaxTime)
       {
           Debug.Log("spawn em");
           InstantiateEnemy();
           enemSpawnTime = enemMinTime;
       }

       if(asteroidHealth <= 0)
       {

           Destroy(gameObject);
           Instantiate();
       }



        
        
    }

    void Instantiate()
    {
        
            Instantiate(gameObject , randomPos , Quaternion.identity);
        
    }

    void InstantiateEnemy()
    {
        Instantiate(enemy , transform.position , Quaternion.identity);
    }


    void setRange()
    {
        spaceMin = new Vector3(-260 , 0 , -1630);

        spaceMax = new Vector3(0 , 1260 , 1630);

    }




    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            
            Destroy(gameObject);
            Instantiate();
           

            //y axis 1260 - 0 
            //x axis -260 - 0;
            //z axis 1630 - -1630
        }

        if(collision.gameObject.tag == "playerBull")
        {
            asteroidHealth --;
            
        }
    }
   


}
