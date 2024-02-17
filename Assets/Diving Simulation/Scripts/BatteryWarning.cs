using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryWarning : MonoBehaviour
{
    // Start is called before the first frame update
    public InformationManager iM;
    private AudioSource batteryAS; 
    bool audioFinished = true;

    bool below15 = false;
    bool prevState = false;

    void Start()
    {
        batteryAS = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float currBattery = iM.GetBatteryLevel(); 
        if (currBattery < 15)
        {
            prevState = below15;
            below15 = true;
        } else {
            prevState = below15;
            below15 = false;
        }
        if (!prevState && below15 && audioFinished) {
            StartCoroutine(AudioCompletion());
        }
    }
    IEnumerator AudioCompletion()
    {
        audioFinished = false;
        batteryAS.Play();
        yield return new WaitForSeconds(batteryAS.clip.length);
        audioFinished = true;
    }
}
