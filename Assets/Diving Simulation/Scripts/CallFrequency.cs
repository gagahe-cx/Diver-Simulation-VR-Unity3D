using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallFrequency : MonoBehaviour
{
    public CallTowerManager ctm;
    private AudioSource aS;
    private bool isBusy = false;
    private bool isIncomingCall = false;

    public AudioClip ringtone;
    private AudioClip incomingCall;
    private int incomingCallerFrequency = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
