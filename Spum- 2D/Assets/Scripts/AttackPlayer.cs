using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class AttackPlayer : MonoBehaviour
{
    public Transform pointShot2;
    public GameObject finalBullet;
    public GameObject bullet;
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            nextAttackTime = Time.time + 1f / attackRate;
            LevelShoot();
        }

    }
    private void LevelShoot()
    {
        switch (Inventory.Instance.darts)
        {
            case 0:
                Shooting(bullet,transform);
                break;
            case 1:
                Shooting(bullet,transform);
                Shooting(bullet,pointShot2);
                break;
            case 2 :
                Shooting(finalBullet,transform);
                break;
        }
    }

    void Shooting(GameObject prefab , Transform position)
    {
        var bul =  Instantiate(prefab, position.position, Quaternion.identity);
        bul.transform.parent = gameObject.transform;
        
        Debug.Log("shoot 1 bullet");
    }
}

