using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Program
{

    public class MenuScript : MonoBehaviour
    {
        [SerializeField] Button settings;
        [SerializeField] Button demo;
        [SerializeField] Transform trans;
        [SerializeField] Rigidbody rb;
        [SerializeField] Collider coll;
        [SerializeField] Image img;
        [SerializeField] VerticalLayoutGroup vert;
        Vector3 vect3 = new Vector3(1, 2, 3);

        Vector2 vect2 = new Vector2(1, 2);

        int age = 10;
        float angle = 65.7f;
        string name = "Alex";




        // Start is called before the first frame update
        void Start()
        {
            //Adds a listener to the Settings button
            settings.onClick.AddListener(goToSettings);
            //Adds a listener to the Start button.
            demo.onClick.AddListener(goToDemo);


            float val = 0;
            val = vect3.x;
            val = vect3.y;
            val = vect3.z;
            val = vect3.magnitude;


            vect3.Set(1, 2, 3);

           
          
    
    }

        // Update is called once per frame
        void Update()
        {

            GameObject.Find("Settings").GetComponent<Button>();





        }

        public void goToSettings()
        {
            //Changes the scene to the settings scene. 
            SceneManager.LoadScene(1);
        }

        public void goToDemo()
        {
            //Changes the scene to the Demo scene.
            SceneManager.LoadScene(2);
        }


        void doNothing ()
        {

        }

        void notNothing (string name, int age)
        {
            name = "";
            age = 20;



        }

        int getAge ()
        {

            int age = 20;

            return age;

        }

       void something ()
        {

            return;

            //The code below return; will never run.

        }





        animal lion = new animal("Lion", 20);










    }


    public class animal
    {

        public animal (string name, int age)
        {

        }



    }


}

