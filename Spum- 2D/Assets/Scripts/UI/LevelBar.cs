using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBar : MonoBehaviour
{
    public Slider slider;
    public TMPro.TextMeshProUGUI levelText;

    public void UpdateLevelBar(int exp, int maxExp )
    {
        slider.maxValue = maxExp;
        slider.value = exp;
    }

    public void UpdateLevelText(int level)
    {
        levelText.text = "Level: " + level.ToString();
    }
}
