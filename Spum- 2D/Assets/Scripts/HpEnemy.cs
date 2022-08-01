using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpEnemy : MonoBehaviour
{
	public int health = 10;
	public Animator anm;
	public GameObject deathEffect;
	
	private static readonly int Dead = Animator.StringToHash("dead");

	public void TakeDamage(int damage)
	{
		health -= damage;
		Debug.Log("dame");
		if (health <= 0)
		{
			Die();
		}
	}
	void Die()
	{
		//anm.SetTrigger(Dead);
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
    private void Destroy()
    {
		Destroy(gameObject);
    }
}
