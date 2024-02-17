using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

using System.Diagnostics;

public class TimeInWater : MonoBehaviour
{
    private System.DateTime currentTime;
    public InformationManager im;
    private Text textBox;
    bool isUnderwater = false, prevState=false;
    DateTime startTime, endTime;
    //float startTime=0, endTime=0;
    Stopwatch stopwatch = new Stopwatch();
        

    // Start is called before the first frame update
    void Start()
    {
        textBox = this.GetComponent<Text>();
        currentTime = DateTime.Now;
        textBox.text = currentTime.ToString("dd MMMM yyyy HH:mm:ss");
    }

    // Update is called once per frame
    void Update()
    {   
        currentTime = DateTime.Now;
        // Debug.Log("Time: " + currentTime.ToString("dd MMMM yyyy HH:mm:ss"));
        textBox.text = currentTime.ToString("dd MMM yyyy HH:mm:ss") + "\n" + "Time in Water: ";

        float currDepth = im.GetDepth();
        if (currDepth < 0f)
        {
            prevState = isUnderwater;
            isUnderwater = true;
        } else
        {
            prevState = isUnderwater;
            isUnderwater = false;
        }
        // Start counting the time underwater
        // if (!prevState && isUnderwater){
        //     startTime = DateTime.Now;
        // } else if(isUnderwater){
        //     Double elapsedMillisecs = ((TimeSpan)(DateTime.Now - startTime)).TotalMilliseconds;
        //     textBox.text += elapsedMillisecs;
        // }
        
        if (!prevState && isUnderwater){ // Getting into the water
            startTime = DateTime.Now;
            stopwatch.Start();
        } else if(isUnderwater){ // Currently in the water
            TimeSpan ts = stopwatch.Elapsed;
            textBox.text += ts.ToString("hh\\:mm\\:ss");
        } else if (prevState && !isUnderwater){ // Gets our of the water
            stopwatch.Stop();
        }

        
        
    }
}
