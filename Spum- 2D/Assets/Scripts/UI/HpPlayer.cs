using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPlayer : MonoBehaviour
{
    public HPBar hPBar;
    public GameObject fxDead;
    public int health;
    public int currentHealth;

    private void Start()
    {
        currentHealth = health;
        hPBar.SetMaxHealth(health);
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth < 1)
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
