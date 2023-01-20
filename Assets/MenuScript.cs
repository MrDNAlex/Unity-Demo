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
        //[SerializeField] Transform trans;
       
        // Start is called before the first frame update
        void Start()
        {
            //Adds a listener to the Settings button
            settings.onClick.AddListener(goToSettings);
            //Adds a listener to the Start button.
            demo.onClick.AddListener(goToDemo);


    }

        // Update is called once per frame
        void Update()
        {


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

    }


}

