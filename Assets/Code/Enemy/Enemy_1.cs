using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Sasha
{
    enum Move_direct : int
    {
        Forward = 0,
        Back = 1,
        Left,
        Right
    }
    public class Enemy_1 : MonoBehaviour
    {
        public GameObject player;
        public float speed;
        public float horizontalSpeed;
        public float rotation_speed;
        public float y_coord;
        public float distance;
        Move_direct _move;
        Vector3 Line_rotate;
        Vector3 dir;
        List<int> last_rand;
       
        // Start is called before the first frame update
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
             dir = Vector3.forward * Time.deltaTime * speed;
            
            _move = Move_direct.Forward;
            Line_rotate = transform.forward;

            last_rand = new List<int>();
        }

        // Update is called once per frame
        void Update()
        {

            //  float dist = Vector3.Distance(player.transform.position, transform.position);



            //Vector3 dir = Vector3.forward * Time.deltaTime * speed;

         

            if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y- y_coord, transform.position.z), Line_rotate, distance))
            {
                print("There is something in front of the object!");
                   dir =  ChangeMove();
               // dir = ChangeMoveRandom();

            }
            Move_to_Object();
           
        }

        Vector3 ChangeMoveRandom()
        {
            int rot;
            rot = Random.Range(0, 3);
            for (int i = 0;i< last_rand.Count-1;i++)
            {
                if(last_rand[i] == rot)
                {
                    rot = Random.Range(0, 3);
                    i = 0;
                }
            }
           
            if(last_rand.Count==3)
            {
                last_rand.Clear();
                last_rand.Add(rot);
                Debug.Log("rot=" + rot);
            }
            else
            {
                last_rand.Add(rot);
                Debug.Log("rot=" + rot);
            }


            switch (rot)
            {
                case 0:
                    Line_rotate = -transform.forward;
                    _move = Move_direct.Back;
                    return Vector3.back * horizontalSpeed * Time.deltaTime;


                case 1:
                    Line_rotate = -transform.right;
                    _move = Move_direct.Left;
                    return Vector3.left * horizontalSpeed * Time.deltaTime;

                case 2:

                    Line_rotate = transform.right;
                    _move = Move_direct.Right;
                    return Vector3.right * horizontalSpeed * Time.deltaTime;

                case 3:
                    Line_rotate = transform.forward;
                    _move = Move_direct.Forward;
                    return Vector3.forward * horizontalSpeed * Time.deltaTime;
            }
                    return dir;
        }

        Vector3 ChangeMove( )
        {
           

            if (_move == Move_direct.Forward)
            {
              
                Line_rotate = -transform.forward;
                _move = Move_direct.Back;
                return Vector3.back * speed * Time.deltaTime;
                 
            }
             if (_move == Move_direct.Back)
            {
             
                Line_rotate = -transform.right;
                _move = Move_direct.Left;
                return Vector3.left * speed * Time.deltaTime;
            }
             if (_move == Move_direct.Left)
            {
              
                Line_rotate = transform.right;
                _move = Move_direct.Right;
                return Vector3.right * speed * Time.deltaTime;
            }
             if (_move == Move_direct.Right)
            {
                
                Line_rotate = transform.forward;
                _move = Move_direct.Forward;
                return Vector3.forward * speed * Time.deltaTime;
            }

            return dir;
        }


        void Move_to_Object()
        {
            transform.Translate(dir);
        }


        void Move_to_Player()
        {
            var look_dir = player.transform.position - transform.position;
            look_dir.y = 0;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(look_dir), rotation_speed * Time.deltaTime);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    
    }

}



