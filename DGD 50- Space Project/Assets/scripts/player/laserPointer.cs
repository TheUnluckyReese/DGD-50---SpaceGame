
using UnityEngine;

public class laserPointer : MonoBehaviour
{
    public Camera fpsCam;
    public float range = 500f ;

    private AudioSource pewpew;

    //public GameObject enemy;


    void Update()
    {
        pewpew = GetComponent<AudioSource>();

        if(Input.GetMouseButtonDown(0))
        {
            PewPew();
            pewpew.PlayOneShot(pewpew.clip);
        }
    }

    void PewPew()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range ))
        {
            Debug.Log(hit.transform.name);

            enemyfollow enemy = hit.transform.GetComponent<enemyfollow>();
            if(enemy != null)
            {

                enemy.health --; //enemy.enemyHit();
            }
            
            Asteroid asteroid = hit.transform.GetComponent<Asteroid>();
            if(asteroid != null)
            {
                asteroid.asteroidHealth --;
                
            }
            
        }

        

    }
}
