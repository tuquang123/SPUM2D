using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpEnemy : MonoBehaviour
{
	public GameObject gem;
	public GameObject deathEffect;
	public int health = 10;
	public void TakeDamage(int damage)
	{
		health -= damage;
		if (health <= 0)
		{
			Die();
		}
	}
	void Die()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Instantiate(gem, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
}
