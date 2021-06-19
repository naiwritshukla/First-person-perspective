using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

public Rigidbody rb;
    void Update()
    {   
        {
           if (Input.GetKey("w"))
           rb.AddForce(0 , 0 , 2000 * Time.deltaTime);
        } 
        {
           if (Input.GetKey("s"))
           rb.AddForce(0 , 0 , -2000 * Time.deltaTime);
        } 
        {
           if (Input.GetKey("d"))
           rb.AddForce(2000 * Time.deltaTime , 0 , 0);
        }
        {
           if (Input.GetKey("a"))
           rb.AddForce(-2000 * Time.deltaTime  , 0 , 0);

        }
        {
           if (Input.GetKey("space"))
           rb.AddForce(0  , 2000 * Time.deltaTime , 0);


        }
        {
           if (Input.GetKey("shift"))
           rb.AddForce(0  , -2000 * Time.deltaTime , 0);
        }


    }
}
