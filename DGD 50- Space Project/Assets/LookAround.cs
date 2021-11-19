using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    public Transform player;
    public int Speed;
    public int Velo;

    public Vector3 SquareDirection;


    float xMouse = 0 ;
    float yMouse = 0 ;  

    public float Sensitivity = 5;

    void Start()
    {

    } 

    void Update()
    {

        transform.Translate(SquareDirection * Speed * Time.deltaTime);

        xMouse += Input.GetAxis("Mouse X") * Sensitivity ;
        yMouse += Input.GetAxis("Mouse Y") * Sensitivity ;

        //yMouse = Mathf.Clamp(yMouse, -90f, 90f);

        transform.localEulerAngles = new Vector3(   yMouse, 0 , 0);
        player.localEulerAngles = new Vector3(0, xMouse, 0 ); 
    } 

    
}
