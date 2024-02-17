using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class OxygenBar : MonoBehaviour
{

    private Slider slider;
    public Text oxygenLevel;
    public InformationManager iM;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        SetMaxOxygenLevel(iM.GetMaxOxygenLevel());
    }

    public void SetMaxOxygenLevel (float maxLevel)
    {
        slider.maxValue = maxLevel;
        slider.value = maxLevel; // Start with max!
    }

    public void SetOxygenLevel (float level)
    {
        slider.value = level;
    }

    public void UpdateOxygenLevelText (float level)
    {
        if (oxygenLevel != null)
        {
            oxygenLevel.text = "Oxygen Level: " + level.ToString("F0") + "%";
        }
    }

    private void Update()
    {
        SetOxygenLevel(iM.GetOxygenLevel());
        UpdateOxygenLevelText (iM.GetOxygenLevel());
    }
}
