using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPlayer : MonoBehaviour
{
    public int health = 10;
    public Animator anm;
    private static readonly int Dead = Animator.StringToHash("dead");

    private static readonly int Hurt = Animator.StringToHash("hurt");
    public void TakeDamage(int damage)
    {
        anm.SetBool(Hurt, true);
        health -= damage;
        Debug.Log("dameE");
        if (health <= 0)
        {
            Die();
        }
        Invoke(nameof(NoHurt),0.5f);
    }
    void NoHurt()
    {
        anm.SetBool(Hurt ,false);
    }
    
    void Die()
    {
        anm.SetTrigger(Dead);
        anm.SetBool(Hurt,false);
    }
    private void Destroy()
    {
        Destroy(gameObject);
    }
}
