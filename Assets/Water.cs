using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody RB = this.GetComponent<Rigidbody>();
        RB.AddForce(Camera.main.transform.forward * 500f, ForceMode.Force);

        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
