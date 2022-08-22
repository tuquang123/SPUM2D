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
    [Range(1,3)]
    public int exp = 0;
    [Range(0,2)]
    public int darts = 0;
    [Range(0,4)]
    public int suriken = 0;
    [Range(0,4)]
    public int boomerang = 0;
    [Range(0,4)]
    public int boom = 0;

    public void AddSuriken()
    {
        suriken++;
    }

    public void AddShoes()
    {
        shoes++;
    }

    public void AddDart()
    {
        darts++;
    }

    public void AddBoom()
    {
        boom++;
    }

    public void AddBoomerang()
    {
        boomerang++;
    }
    
}
