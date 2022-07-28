using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    public Animator animator;
    public Transform AttackPoint;
    public LayerMask enemyLayers;



    public int damage = 2;
    public float attackRage = 0.5f;
    public float attackRate = 2f;
    float nextAttackTime = 0f;

    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                AttAnimation();
                Att();
                nextAttackTime = Time.time + 1f / attackRate;

            }
        }

    }
    void AttAnimation()
    {
        //play attack animation
        animator.SetTrigger("att");
    }

    void Att()
    {
        //Nhan dien enemy va attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, attackRage, enemyLayers);

        //dame them
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<HpEnemy>().TakeDamage(damage);
        }

    }

    // draw radius att
    void OnDrawGizmosSelected()
    {
        if (AttackPoint == null)
            return;
        Gizmos.DrawWireSphere(AttackPoint.position, attackRage);
    }

}

