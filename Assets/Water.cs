using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        PlayerControls controls = GameObject.Find("Player").GetComponent<PlayerControls>();
        Rigidbody RB = this.GetComponent<Rigidbody>();
        RB.velocity = Camera.main.transform.forward * controls.gPower;
        //RB.AddForce(Camera.main.transform.forward * 500f * controls.gPower, ForceMode.Force);

        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
