using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class AttackPlayer : MonoBehaviour
{
    public GameObject bullet;
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            nextAttackTime = Time.time + 1f / attackRate;
            var bul =  Instantiate(bullet, transform.position, Quaternion.identity);
            bul.transform.parent = gameObject.transform;
        }

    }
}

