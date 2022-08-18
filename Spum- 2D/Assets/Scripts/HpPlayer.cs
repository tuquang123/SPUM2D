using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPlayer : MonoBehaviour
{
    public GameObject fxDead;
    public int health = 10;
    int currentHealth;
    public HPBar hPBar;
    Animator anm;
    
    private static readonly int Dead = Animator.StringToHash("dead");
    private void Start()
    {
        anm = GetComponent<Animator>();
        currentHealth = health;
        hPBar.SetMaxHealth(health);
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
        hPBar.SetHealth(currentHealth);
    }
    void Die()
    {
        Destroy(gameObject);
        Instantiate(fxDead, transform.position, Quaternion.identity);
    }
}
