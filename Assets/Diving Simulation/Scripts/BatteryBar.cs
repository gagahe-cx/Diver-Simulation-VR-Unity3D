using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class BatteryBar : MonoBehaviour
{

    private Slider slider;
    public Text batteryLevel;
    public Image fillImage;
    public InformationManager iM;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        SetMaxBatteryLevel(iM.GetMaxBatteryLevel());
    }

    public void SetMaxBatteryLevel (float maxLevel)
    {
        slider.maxValue = maxLevel;
        slider.value = maxLevel; // Start with max!
        
    }

    public void SetBatteryLevel (float level)
    {
        slider.value = level;
    }

    public void UpdateBatteryLevelText (float level)
    {
        if (batteryLevel != null)
        {
            batteryLevel.text = "Battery Level: " + level.ToString("F0") + "%";
        }
    }

    private void Update()
    {
        SetBatteryLevel(iM.GetBatteryLevel());
        UpdateBatteryLevelText(iM.GetBatteryLevel());
        if (iM.GetBatteryLevel() < 15)
        {
            fillImage.color = Color.red;
        }
    }
}
