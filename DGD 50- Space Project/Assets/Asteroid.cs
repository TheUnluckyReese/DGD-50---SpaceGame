using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public int asteroidHealth = 5;
    public float enemSpawnTime, enemMax, enemMin;

    public Vector3 spaceMin;
    public Vector3 spaceMax;

    public GameObject enemy;

    public float xAxis, yAxis, zAxis;

    public Vector3 randomPos;

    public bool isHit;

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
        
        
    }

    void setRange()
    {
        spaceMin = new Vector3(-260 , 0 , -1630);

        spaceMax = new Vector3(0 , 1260 , 1630);

    }

    void Instantiate()
    {
        if(isHit == true )
        {
            Instantiate(gameObject , randomPos , Quaternion.identity);
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("relocate");
            Instantiate();

            //y axis 1260 - 0 
            //x axis -260 - 0;
            //z axis 1630 - -1630
        }

        if(collision.gameObject.tag == "playerBull")
        {
            asteroidHealth --;
            Debug.Log("Asteroid Health");
        }
    }
   


}
