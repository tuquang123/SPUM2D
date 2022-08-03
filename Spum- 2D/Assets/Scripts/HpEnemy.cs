using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpEnemy : MonoBehaviour
{
	public GameObject fx;
	public int health = 10;
	public Animator anm;
	public GameObject deathEffect;
	
	private static readonly int Dead = Animator.StringToHash("dead");
	private static readonly int Hurt = Animator.StringToHash("hurt");

	public void TakeDamage(int damage)
	{
		Instantiate(fx, transform.position, Quaternion.identity);
		anm.SetBool(Hurt, true);
		health -= damage;
		Debug.Log("dame");
		if (health <= 0)
		{
			Die();
		}
		Invoke(nameof(NoHurt),0.3f);
		Enemy enemy = GetComponent<Enemy>();
		enemy.speed = 0;
	}
	void NoHurt()
	{
		anm.SetBool(Hurt ,false);
		Enemy enemy = GetComponent<Enemy>();
		enemy.speed = .5f;
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
