using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBook : MonoBehaviour
{
    public GameObject bullet;
    //public float attackRate = 2f;
    float nextAttackTime = 0f;

    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            nextAttackTime = Time.time + 1f / Inventory.Instance.book;
            Shooting();
        }

    }
    void Shooting()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
