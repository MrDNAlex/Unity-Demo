using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //4 Directional Movement Code
       if (Input.GetKey(KeyCode.W))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.forward * 20f, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.left * 20f, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.right * 20f, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.back * 20f, ForceMode.Force);
        }


        //Jumping Code
        if (Input.GetKey(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 100f, ForceMode.Force);
        }
    }
}
