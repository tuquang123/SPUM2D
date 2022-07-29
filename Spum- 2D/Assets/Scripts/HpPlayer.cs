using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPlayer : MonoBehaviour
{
    public int health = 10;
    public Animator anm;
    private static readonly int Dead = Animator.StringToHash("dead");

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("dameE");
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        anm.SetTrigger(Dead);
    }
    private void Destroy()
    {
        Destroy(gameObject);
    }
}
