using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDame : MonoBehaviour
{
    public int dame;
    private void OnTriEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            HpEnemy enemy = other.GetComponent<HpEnemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(dame);
                //Instantiate(bullet, transform.position, Quaternion.identity);
                //Destroy(gameObject);
            }
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            HpEnemy enemy = other.GetComponent<HpEnemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(dame);
                //Instantiate(bullet, transform.position, Quaternion.identity);
                //Destroy(gameObject);
            }
        }
    }
}
