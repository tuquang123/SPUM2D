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
    public int gold ;
    public int kill;
    [Range(0, 4)]
    public int speed, speedAttack, drill, rocket2, shuriken,thunder, radiate,speedAttackBasic, speedAttackThunder,attackSpeedSaw ,boom,book;
}
