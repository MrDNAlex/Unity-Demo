using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] LayerMask ground;
    [SerializeField] Transform camera;
    [SerializeField] GameObject waterP;

    [SerializeField] Text speedometer;
    [SerializeField] Text power;

    Vector3 vertMov;

    float mSpeed = 10f;

    bool jump;

    float xRot;
    float yRot;

    public float gPower = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        cameraMovement();
        waterGun();

        if (Input.GetKey(KeyCode.Z))
        {
            gPower += 0.1f;

        }

        if (Input.GetKey(KeyCode.X))
        {
            gPower -= 0.1f;

            gPower = Mathf.Clamp(gPower, 1, 2);

        }


        //4 Directional Movement Code
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 dir = camera.transform.forward;
            dir.y = 0;
           this.GetComponent<Rigidbody>().AddForce(dir * 10f, ForceMode.Force);
           
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 dir = camera.transform.right *-1;
            dir.y = 0;
            this.GetComponent<Rigidbody>().AddForce(dir * 10f, ForceMode.Force);
           
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 dir = camera.transform.right;
            dir.y = 0;
            this.GetComponent<Rigidbody>().AddForce(dir * 10f, ForceMode.Force);
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 dir = camera.transform.forward*-1;
            dir.y = 0;
            this.GetComponent<Rigidbody>().AddForce(dir * 10f, ForceMode.Force);
            
        }

        //Jumping Code
        if (Input.GetKey(KeyCode.Space))
        {
            //Checks if the ground is within 1.5f distance below the player. 
            if (Physics.Raycast(this.transform.position, Vector3.down, 1.5f, ground))
            {
                jump = true; 
            } else
            {
                jump = false; 
            }
        }

        if (jump == true)
        {
            this.GetComponent<Rigidbody>().velocity = this.GetComponent<Rigidbody>().velocity.normalized*mSpeed + Vector3.up * 2f;
            jump = false; 
        }

        Vector3 vert = new Vector3(0, this.GetComponent<Rigidbody>().velocity.y, 0);
        Vector3 mov = new Vector3(this.GetComponent<Rigidbody>().velocity.x, 0f, this.GetComponent<Rigidbody>().velocity.z).normalized * mSpeed;

        if (this.GetComponent<Rigidbody>().velocity.magnitude > mSpeed)
        {
            this.GetComponent<Rigidbody>().velocity = mov + vert;
        }

        float speed = this.GetComponent<Rigidbody>().velocity.magnitude;
        speedometer.text = "Speed : " + speed;

        power.text = "Power : " + gPower;


    }

    public void cameraMovement()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * 400;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * 400;

        yRot += mouseX;
        xRot -= mouseY;

        xRot = Mathf.Clamp(xRot, -90f, 90f);

        this.transform.rotation = Quaternion.Euler(0, yRot, 0);
        camera.transform.rotation = Quaternion.Euler(xRot, yRot, 0);


    }

    public void waterGun ()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            GameObject.Instantiate(waterP, camera.transform.position + camera.transform.forward * 1f, new Quaternion(0, 0, 0, 0));

        }
    }


}
