using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackThunder : MonoBehaviour
{
    public GameObject bullet;
    //public float attackRate = 2f;
    float nextAttackTime = 0f;

    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            nextAttackTime = Time.time + 1f / Inventory.Instance.speedAttackThunder;
            Shooting();
        }

    }
    void Shooting()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
