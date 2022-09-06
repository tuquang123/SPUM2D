using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPlayer : MonoBehaviour
{
    public GameObject selectItemPanel;
    public LevelBar levelBar;
    public int level = 1;
    public int maxExp = 10;
    public int exp;

    private void Start()
    {
        levelBar.UpdateLevelBar(exp, maxExp);
        levelBar.UpdateLevelText(level);
    }

    private void Update()
    {
        UpLevel();
    }

    private void UpLevel()
    {
        levelBar.UpdateLevelBar(exp, maxExp);
        if (exp >= maxExp)
        {
            level++;
            maxExp += 10;
            exp = 0;
            levelBar.UpdateLevelText(level);
            //selectItemPanel.SetActive(true);
            //Time.timeScale = 0;
        }
    }
    //call to button 
    public void ContinueGame()
    {
        Time.timeScale = 1;
        selectItemPanel.SetActive(false);
    }
}
