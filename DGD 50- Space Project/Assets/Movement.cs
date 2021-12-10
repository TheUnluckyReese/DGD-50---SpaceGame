    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Movement : MonoBehaviour
    {
       
        public int speed, velo , height;
        public Vector3 mouseDirection;


        void Update()
        {

            

            //transform.Translate(mouseDirection *speed *Time.deltaTime); 
            //mouseDirection = Camera.main.ScreenToWorldPoint(mouseDirection);
            
            
            //transform.Translate(mouseDirection *speed *Time.deltaTime);
            //transform.position = Vector3.Lerp(transform.position, mouseDirection , speed); 

            
            //MouseDirection = Input.MouseDirection;
            // /MouseDirection = Camera.main.ScreenToWorldPoint(MouseDirection);
             
        }
        /*
        // incative code
        public Vector3 MouseDirection;
        public int speed; 



        public int speed, velo , height;
        public Vector3 SquareDirection;

        //public Vector3 newRotation =  new Vector3(0 ,10 , 0);

        void Start()
        {
            Debug.Log("ScriptIsOn");
        }

        void Update()
        {


            /*00
            //doesn't work for y direction
            SquareDirection = new Vector3 (0 , Height , 10);

            transform.Translate(SquareDirection *speed *Time.deltaTime);   

         
            */
        
    }
