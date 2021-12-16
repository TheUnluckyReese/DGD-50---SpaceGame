using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbullets : MonoBehaviour
{
    public GameObject lasers;

    public float speed ;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject laserAppear = Instantiate(lasers, transform.position , Quaternion.identity) as GameObject;

            Rigidbody laserAppearRB = laserAppear.GetComponent<Rigidbody>();
            lasers.transform.position = transform.position + Camera.main.transform.forward *2;

            laserAppearRB.AddForce(-Vector3.forward * speed);
            //laserAppearRB.velocity = Camera.main.transform.forward * 40;

            Destroy(laserAppear , 2f );


        }
    }

    void OnCollisionEnter(Collision collision)
    {
        
    }
}
