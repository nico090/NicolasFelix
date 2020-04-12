using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{

    Rigidbody rgbd;
    public float speed;

   public bool adelante;
    public bool atras;
    // Start is called before the first frame update
    void Start()
    {
        rgbd = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        RuedasDelanteras();


        RuedasTraseras();
    }



    void RuedasTraseras()
    {
        if (Input.GetKey(KeyCode.W))
        {


            rgbd.AddForce(Vector3.forward* speed, ForceMode.Impulse);


        }


        if (Input.GetKey(KeyCode.S))
        {


            rgbd.AddForce(Vector3.forward * -speed, ForceMode.Impulse);


        }


       


    }



    void RuedasDelanteras()
    {

       

        if (Input.GetKey(KeyCode.A))
        {


            


        }


    }
}
