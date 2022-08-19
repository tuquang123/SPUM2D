using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPlayer : MonoBehaviour
{
    public GameObject selectItemPanel;
    public int level = 1;
    public int maxExp = 10;
    public int exp;
    private void Update()
    {
        UpLevel();
    }

    private void UpLevel()
    {
        if (exp > maxExp)
        {
            level= Inventory.Instance.exp;
            maxExp++;
            exp = 0;
            
            selectItemPanel.SetActive(true);
            //Time.timeScale = 0;
        }
    }
    //call to button 
    public void ContinueGame()
    {
        //Time.timeScale = 1;
        selectItemPanel.SetActive(false);
        //UpLevel();
    }
}
