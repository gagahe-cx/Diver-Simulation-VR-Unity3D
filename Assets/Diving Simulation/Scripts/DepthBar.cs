using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class DepthBar : MonoBehaviour
{
    private Slider slider;
    public Text depthLevel;
    public InformationManager iM;

    private bool shouldUpdateDepth = false;

    void Start()
    {
        slider = GetComponent<Slider>();
        SetMaxDepthLevel(20f); 
    }

    public void SetMaxDepthLevel(float maxLevel)
    {
        slider.maxValue = maxLevel;
        //slider.value = maxLevel; // start at max
    }

    public void SetDepthLevel(float level)
    {
        // 将深度值的绝对值传递给slider
        slider.value = Mathf.Abs(level);
        
        // 更新深度文本
        UpdateDepthLevelText(level);
    }

    public void UpdateDepthLevelText(float level)
    {
        if (depthLevel != null)
        {
            // 使用深度的绝对值
            depthLevel.text = "Depth:\n" + (Mathf.Abs(level)).ToString("F2") + "m";
        }
    }

    private void Update()
    {
        float currentDepth = iM.GetDepth();

        // 只有在水下时才更新深度
        if (currentDepth < 0f)
        {
            SetDepthLevel(currentDepth);
            UpdateDepthLevelText(currentDepth);
        }

    }
}
