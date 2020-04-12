using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto : MonoBehaviour
{

  
    public float fzarotacion;
    public bool adelante;
    public bool atras;
    
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


            transform.localRotation = new Quaternion(transform.rotation.x, transform.rotation.y + fzarotacion, transform.rotation.z, transform.rotation.w);



        }






    }




    public void MovimientoAuto(int index)
    {
        switch (index)
        {
            case 0:

                


                break;


            case 1:
               

                break;

        }



    }
}
