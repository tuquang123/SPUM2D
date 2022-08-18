using System;
using System.Collections;
using System.Collections.Generic;
using Ingame;
using UnityEngine;

public class Inventory : Singleton<Inventory>
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    public int kill = 0;
    public int gold = 0;
    
    [Range(0,2)]
    public int shoes = 0;
    [Range(0,2)]
    public int exp = 0;
    [Range(0,2)]
    public int darts = 0;
}
