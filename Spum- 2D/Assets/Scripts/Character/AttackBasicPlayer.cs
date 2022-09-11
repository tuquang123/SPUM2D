using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBasicPlayer:MonoBehaviour
{
    public GameObject bullet;
    float nextAttackTime = 0f;

    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            nextAttackTime = Time.time + 1f / Inventory.Instance.speedAttackBasic;
            Shooting();
        }

    }
    void Shooting()
    {
        //for(int i = 0;i < Inventory.Instance.darts+1; i++)
        {
            var transForm = transform.position;
            Instantiate(bullet, transForm, Quaternion.identity);
        }
    }
}
