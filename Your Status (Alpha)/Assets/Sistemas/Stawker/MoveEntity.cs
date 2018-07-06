using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEntity : MonoBehaviour
    {
        public float speed;
        private Vector3 dir;
        public bool stop; 
        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            if(stop == true)
            {
                speed = 0;
                dir = new Vector3(speed, 0, 0);
            }
            else
            {
                if (transform.position.x >= 8)
                {
                    dir = new Vector3(-speed, 0, 0);
                }
                else if (this.transform.position.x <= -8)
                {
                    dir = new Vector3(speed, 0, 0);
                }
            }

            transform.position += dir;
        }

}
