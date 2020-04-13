using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto : MonoBehaviour
{

  
    public float fzarotacion;
    public bool adelante;
    public bool atras;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
      
    }

    // Update is called once per frame
    void Update()
    {
        InputMovimiento();
    }
  
    void InputMovimiento()
    {

        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(Vector3.up, fzarotacion * Time.deltaTime);



        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(Vector3.up, -fzarotacion * Time.deltaTime);



        }

        if (Input.GetKey(KeyCode.W))
        {


            transform.Translate(Vector3.forward * speed * Time.deltaTime);



        }


        if (Input.GetKey(KeyCode.S))
        {


            transform.Translate(Vector3.forward * -speed * Time.deltaTime);


        }


    }




   
}
