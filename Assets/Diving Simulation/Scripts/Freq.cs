using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

using System.Diagnostics;

public class Freq : MonoBehaviour
{

    public CallTowerManager ctm;
    public InformationManager im;
    public AudioClip soundEffect;
    private AudioSource aS;
    private Text textBox;
    // Stopwatch stopwatch = new Stopwatch();
    int interval;
    DateTime startTime, currentTime;

    // Start is called before the first frame update
    void Start()
    {
        // aS = GetComponent<AudioSource>();
        // aS.clip = soundEffect;
        textBox = this.GetComponent<Text>();
        textBox.text = "";
        startTime = DateTime.Now;

        // (DateTime.Now - startTime).Milliseconds;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = DateTime.Now;
    }
    public void add1()
    {
        if((currentTime - startTime).Milliseconds>800){
            // aS.Play();
            textBox.text = textBox.text + "1";
            startTime = currentTime;
        }
    }
    public void add2()
    {
        if((currentTime - startTime).Milliseconds >800){
            // aS.Play();
            textBox.text = textBox.text + "2";
            startTime = currentTime;
        }
    }
    public void add3()
    {
        if((currentTime - startTime).Milliseconds >800){
            // aS.Play();
            textBox.text = textBox.text + "3";
            startTime = currentTime;
        }
    }
    public void add4()
    {
        if((currentTime - startTime).Milliseconds >800){
            // aS.Play();
            textBox.text = textBox.text + "4";
            startTime = currentTime;
        }
    }
    public void add5()
    {
        if((currentTime - startTime).Milliseconds >800){
            // aS.Play();
            textBox.text = textBox.text + "5";
            startTime = currentTime;
        }
    }
    public void add6()
    {
        if((currentTime - startTime).Milliseconds >800){
            // aS.Play();
            textBox.text = textBox.text + "6";
            startTime = currentTime;
        }
    }
    public void add7()
    {
        if((currentTime - startTime).Milliseconds >800){
            // aS.Play();
            textBox.text = textBox.text + "7";
            startTime = currentTime;
        }
    }
    public void add8()
    {
        if((currentTime - startTime).Milliseconds >800){
            // aS.Play();
            textBox.text = textBox.text + "8";
            startTime = currentTime;
        }
    }
    public void add9()
    {
        if((currentTime - startTime).Milliseconds >800){
            // aS.Play();
            textBox.text = textBox.text + "9";
            startTime = currentTime;
        }
    }
    public void add0()
    {
        if((currentTime - startTime).Milliseconds >800){
            // aS.Play();
            textBox.text = textBox.text + "0";
            startTime = currentTime;
        }
    }
    public void clear()
    {
        // aS.Play();
        textBox.text = "";
        // Debug.Log(charHolder.text);
    }
}
