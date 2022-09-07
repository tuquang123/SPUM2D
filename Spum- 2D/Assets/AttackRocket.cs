using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRocket : MonoBehaviour
{
    public GameObject bullet;
    public float attackRate = 2f;
    float nextAttackTime = 0f;

    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            nextAttackTime = Time.time + 1f / attackRate;
            Shooting();
        }

    }
   
    void Shooting()
    {
        var bul = Instantiate(bullet,transform.position, Quaternion.identity);
        //bul.transform.parent = gameObject.transform;
        //Debug.Log("shoot 1 bullet");
    }
}
