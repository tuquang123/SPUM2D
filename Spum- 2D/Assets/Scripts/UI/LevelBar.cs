using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBar : MonoBehaviour
{
    public Slider slider;

    public void UpdateLevelBar(int exp, int maxExp )
    {
        slider.maxValue = maxExp;
        slider.value = exp;
    }
}
