using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPlayer : MonoBehaviour
{
    public HPBar hPBar;
    public GameObject fxDead;
    public int health = 10;
    int currentHealth;
    
    private void Start()
    {
        currentHealth = health;
        hPBar.SetMaxHealth(health);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            TakeDamage(2);
        }
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
