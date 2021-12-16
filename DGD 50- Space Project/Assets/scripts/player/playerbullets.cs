using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbullets : MonoBehaviour
{
    public GameObject lasers;
    
    private AudioSource pewpew;
    //public Camera cam;

    public float speed ;

    //experimenting

    //public Vector3 screenCenter = new Vector3(0.5f , 0.5f, 0);

    //public Vector3 laserPoint = cam.ViewportToWorldPoint(screenCenter);

    


    void Update()
    {
        pewpew = GetComponent<AudioSource>();

       
        if(Input.GetMouseButtonDown(0))
        {
            pewpew.PlayOneShot(pewpew.clip);

            GameObject laserAppear = Instantiate(lasers, transform.position , Quaternion.identity) as GameObject;

            Rigidbody laserAppearRB = laserAppear.GetComponent<Rigidbody>();
            lasers.transform.position = transform.position - Camera.main.transform.forward *2;

            laserAppearRB.AddForce(-Vector3.forward * speed);
            //laserAppearRB.velocity = Camera.main.transform.forward * 40;

            Destroy(laserAppear , 2f );
        }


        
    }

    void OnCollisionEnter(Collision collision)
    {
        
    }
}
