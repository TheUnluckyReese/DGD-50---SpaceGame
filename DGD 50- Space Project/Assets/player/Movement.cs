    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Movement : MonoBehaviour
    {
        float xMouse = 0;
        float yMouse = 0;
        public int speed, velo , height;
        public int playZ ;

        public Vector3 SquareDirection;


        void Update()
        { 
        
            xMouse += Input.GetAxis("Mouse X") * speed;
            yMouse -= Input.GetAxis("Mouse Y") * speed;

            yMouse = Mathf.Clamp(yMouse, -90f, 90f);

            SquareDirection = new Vector3 (xMouse, yMouse , playZ);

            transform.Translate(SquareDirection *speed *Time.deltaTime);
        }

         
        
    }
