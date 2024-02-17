using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Keypad : MonoBehaviour
{
    public CallTowerManager ctm;
    public InformationManager im;
    public TMP_InputField charHolder;
    public InputField charHolder1;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button0;
    public GameObject button_clear;
    public GameObject button_enter;
    public int phone_number;
    private int code;
    private int[] crewmate_codes;
    public Text textBox;
    
    // Start is called before the first frame update
    void Start()
    {
        CrewInfo[] crewInformation = ctm.GetCrewmatesInformation();
        charHolder = this.GetComponent<TMP_InputField>();
        // charHolder = this.GetComponent<InputField>();
        crewmate_codes = ctm.crewmateFrequencies;
        textBox = this.GetComponent<Text>();
        textBox.text = "Frequencies:";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Call to " + code);
    }

    public void b1()
    {
        textBox.text = textBox.text + "1";
        Debug.Log(charHolder.text);
    }
    
    public void b2()
    {
        textBox.text = textBox.text + "2";
        Debug.Log(charHolder.text);

    }
    public void b3()
    {
        textBox.text = textBox.text + "3";
        Debug.Log(charHolder.text);

    }
    public void b4()
    {
        textBox.text = textBox.text + "4";
        Debug.Log(charHolder.text);

    }
    public void b5()
    {
        textBox.text = textBox.text + "5";
        Debug.Log(charHolder.text);

    }
    public void b6()
    {
        charHolder.text = charHolder.text + "6";
        Debug.Log(charHolder.text);

    }
    public void b7()
    {
        charHolder.text = charHolder.text + "7";
        Debug.Log(charHolder.text);

    }
    public void b8()
    {
        charHolder.text = charHolder.text + "8";
        Debug.Log(charHolder.text);

    }
    public void b9()
    {
        charHolder.text = charHolder.text + "9";
    }
    public void b0()
    {
        charHolder.text = charHolder.text + "0";
    }
    
    public void clearEvent()
    {
        charHolder.text = null;
    }
    
    public int enterEvent()
    {
        code = int.Parse(charHolder.text);
        Debug.Log("Call to "+code);
        return code;
    }
}