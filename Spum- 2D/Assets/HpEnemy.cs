using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpEnemy : MonoBehaviour
{
	public int health = 10;
	public Animator anm;
	public GameObject deathEffect;

	public void TakeDamage(int damage)
	{
		health -= damage;
		if (health <= 0)
		{
			Die();
			Debug.Log("dame");
		}
	}
	void Die()
	{
		anm.SetTrigger("dead");
		//Instantiate(deathEffect, transform.position, Quaternion.identity);
		//Destroy(gameObject);
	}
    private void Destroy()
    {
		Destroy(gameObject);
    }
}
