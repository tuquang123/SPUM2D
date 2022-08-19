using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken : MonoBehaviour
{
    public GameObject[] shuriken;

    private void Start()
    {
       CheckShuriken();
    }
    //call when button click
    public void AddShuriken()
    {
        Inventory.Instance.suriken++;
        CheckShuriken();
    }
    public void CheckShuriken()
    {
        for (int i = 0; i < Inventory.Instance.suriken; i++)
        {
            shuriken[i].SetActive(true);
        }
    }
}
