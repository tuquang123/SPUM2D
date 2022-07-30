using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator anm;
    private  Rigidbody rb;
    public float speed = 5f;
    public Transform target;

    public float minimumDistance;
    private static readonly int Run = Animator.StringToHash("run");
    private static readonly int Att = Animator.StringToHash("att");
    
    public float attackRate = 1f;
    public float nextAttackTime = 0f;
    
    public int damage = 1;
    public float attackRage = 0.5f;
    public Transform attackPoint;
    public LayerMask enemyLayers;
    void Attack()
    {
        //Nhan dien enemy va attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRage, enemyLayers);

        //dame them
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<HpPlayer>().TakeDamage(damage);
        }

    }
    // draw radius att
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRage);
    }
    private void FixedUpdate()
    {
        if (target == null)
        {
            anm.SetBool(Run, false);
        }
        else if (target)
        {
            if (Vector2.Distance(transform.position,target.position) > minimumDistance)//&& check.gg == false)
            {
                anm.SetBool(Run, true);
                transform.position =
                    Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
            if (Vector2.Distance(transform.position, target.position) <= minimumDistance) //&& check.gg == true)
            {
                if (Time.time >= nextAttackTime)
                {
                    anm.SetBool(Run, false);
                    AttackAnimation();
                    Attack();
                    nextAttackTime = Time.time + 1f / attackRate;
                }
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, minimumDistance);
    }
    void AttackAnimation()
    {
        anm.SetTrigger(Att);
    }
}