using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpEnemy : MonoBehaviour
{
	public Enemy enemy;
	public GameObject FloatTextPrefab;
	public GameObject deathEffect;
	public GameObject fx;
	public int health = 10;
	public Animator anm;
	
	private static readonly int Dead = Animator.StringToHash("dead");
	private static readonly int Hurt = Animator.StringToHash("hurt");


	void ShowFloatingText(string text)
	{
		var go = Instantiate(FloatTextPrefab, transform.position, Quaternion.identity, transform);
		go.GetComponentInChildren<TextMesh>().text = text;
	}

	IEnumerator DamageAnimation()
	{
		SpriteRenderer[] srs = GetComponentsInChildren<SpriteRenderer>();

		for (int i = 0; i < 3; i++)
		{
			foreach (SpriteRenderer sr in srs)
			{
				Color c = sr.color;
				c.a = 0;
				sr.color = c;
			}

			yield return new WaitForSeconds(.1f);

			foreach (SpriteRenderer sr in srs)
			{
				Color c = sr.color;
				c.a = 1;
				sr.color = c;
			}

			yield return new WaitForSeconds(.1f);
		}
	}
	public void TakeDamage(int damage)
	{
		StartCoroutine(DamageAnimation());
		Instantiate(fx, transform.position, Quaternion.identity);
		anm.SetBool(Hurt, true);
		health -= damage;
		Debug.Log("dame");
		if (health <= 0)
		{
			Die();
		}
		Invoke(nameof(NoHurt),1f);
		
		enemy.speed = 0;
		if (FloatTextPrefab && health > 0)
		{
			//ShowFloatingText(damage.ToString());
		}
	}
	void NoHurt()
	{
		anm.SetBool(Hurt ,false);
		
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
