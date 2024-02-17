using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrewmateNames : MonoBehaviour
{

    public CallTowerManager ctm;
    public InformationManager im;
    private Text textBox;

    // Start is called before the first frame update
    void Start()
    {
        textBox = this.GetComponent<Text>();
        textBox.text = "Crewmate Info:";
    }

    // Update is called once per frame
    void Update()
    {
        CrewInfo[] crewInformation = ctm.GetCrewmatesInformation();
        string crewText = "";
        
        for (int i = 0; i < crewInformation.Length; i++){
            CrewInfo currCrewmate = crewInformation[i];
            // print("Distance " + im.GetDistanceTo(currCrewmate.worldLocation));
            string currName = currCrewmate.name;
            string currPosition = currCrewmate.worldLocation.ToString();
            string freq = currCrewmate.frequency.ToString();

            crewText += currName + " call(" + freq + ")" + " dist(" + im.GetDistanceTo(currCrewmate.worldLocation) + ")" + "\n" + currPosition;
            if (i < crewInformation.Length - 1){crewText += "\n";}
        }


        textBox.text = crewText;
    }
}
