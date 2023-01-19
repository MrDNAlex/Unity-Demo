using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    [SerializeField] GameObject target; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (transform.childCount < 10)
        {
            Instantiate(target, new Vector3(Random.RandomRange(-10f, 10f), 4f, Random.RandomRange(-10f, 10f)), new Quaternion(0,0,0,0), this.transform);
        }
    }
   
    
}
