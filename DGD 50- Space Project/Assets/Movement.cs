    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Movement : MonoBehaviour
    {
        public int speed;
        public int velo;

        public float xAngle , yAngle , zAngle;

        public Vector3 SquareDirection;
        Vector3 newRotation =  new Vector3(0 ,10 , 0);

        void Start()
        {
            Debug.Log("ScriptIsOn");
        }

        void Update()
        {
            transform.Translate(SquareDirection *speed *Time.deltaTime);

            //transform.position = newPosition;
            //transform.eulerAngles = newRotation;

           // Quaternion objectRotation = otherObject.transform.rotation;
            //transform.rotation = objectRotation;

            if(Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("RotateLeft");  
            }

            if(Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("RotateRight");   
            }
        }
    }
