using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbullets : MonoBehaviour
{
    public GameObject lasers;
    public float speed;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject laserAppear = Instantiate(lasers, transform.position , Quaternion.identity);

            Rigidbody laserAppearRB = laserAppear.GetComponent<Rigidbody>();

            laserAppearRB.AddForce(gameObject.transform.forward * speed);
            Destroy(laserAppear , 3f );


        }
    }
}
