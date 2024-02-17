using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenOpenClose : MonoBehaviour
{

    public GameObject screen;
    private bool activate = true;


    // Start is called before the first frame update
    void Start()
    {
        screen.SetActive(activate);
        // print("Start with active screen: " + activate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenCloseScreen()
    {
        activate = !activate;
        // print("screen is active: " + activate);
        screen.SetActive(activate);
    }
}
