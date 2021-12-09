    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Movement : MonoBehaviour
    {
        public int speed;
        public int velo;

        public int Height;

        public Vector3 SquareDirection;

        //public Vector3 newRotation =  new Vector3(0 ,10 , 0);

        void Start()
        {
            Debug.Log("ScriptIsOn");
        }

        void Update()
        {

            SquareDirection = new Vector3 (0 , Height , 10);

            transform.Translate(SquareDirection *speed *Time.deltaTime);    

        }
    }
