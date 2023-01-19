using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour
{
    [SerializeField] Text title;
    [SerializeField] Text language;
    [SerializeField] Button lan1;
    [SerializeField] Button lan2;
    [SerializeField] Text volume;
    [SerializeField] Slider volumeSlide;
    [SerializeField] Button back;

    int vol = 0;
    bool isEnglish = true; 

    // Start is called before the first frame update
    void Start()
    {
        //Add Listerners to the 2 Language buttons.
        lan1.onClick.AddListener(setLanEng);
        lan2.onClick.AddListener(setLanFrench);
        //Go back to the menu.
        back.onClick.AddListener(goBack);

        volumeSlide.onValueChanged.AddListener(delegate { setVolume(); });

        setLanEng();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setLanEng ()
    {
        //Change the text the text boxes will display. 
        title.text = "Settings";
        language.text = "Language : English";
        volume.text = "Volume : " + vol;

        //Change the text displayed on the buttons. 
        lan1.transform.GetChild(0).GetComponent<Text>().text = "English";
        lan2.transform.GetChild(0).GetComponent<Text>().text = "French";
        back.transform.GetChild(0).GetComponent<Text>().text = "Back";

    }

    public void setLanFrench ()
    {
        //Change the text the text boxes will display. 
        title.text = "Paramètre";
        language.text = "Langue : Français";
        volume.text = "Volume : " + vol;

        //Change the text displayed on the buttons. 
        lan1.transform.GetChild(0).GetComponent<Text>().text = "Englais";
        lan2.transform.GetChild(0).GetComponent<Text>().text = "Français";
        back.transform.GetChild(0).GetComponent<Text>().text = "Retourne";
    }

    public void goBack ()
    {
        //Changes scene to the menu.
        SceneManager.LoadScene(0);
    }

    public void setVolume ()
    {
        vol = (int)volumeSlide.value;

        if (isEnglish == true)
        {
            //English Text
            volume.text = "Volume : " + vol;
        } else
        {
            //French Text
            volume.text = "Volume : " + vol;
        }
        
    }


}
