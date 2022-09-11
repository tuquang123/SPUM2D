using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpEnemy : MonoBehaviour
{
	public int dame = 2;
	//public GameObject gem;
	public GameObject deathEffect;
    //public GameObject attackEffect;
    public GameObject floatingDame;
	public int health;

    public void TakeDamage(int damage)
	{
		ShowDame(damage.ToString());
        //Instantiate(attackEffect, transform.position, Quaternion.identity);
        health -= damage;
		if (health <= 0)
		{
			Die();
		}
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
	    if(col.CompareTag("Player"))
	    {
		    HpPlayer enemy = col.GetComponent<HpPlayer>();
		    if (enemy != null)
		    {
			    enemy.TakeDamage(dame);
			    Die();
		    }
	    }
    }
	void ShowDame(string text)
    {
		if(floatingDame)
        {
			GameObject prefabDame = Instantiate(floatingDame, transform.position, Quaternion.identity);
			prefabDame.GetComponentInChildren<TextMesh>().text = text;
        }
    }
	void Die()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		//Instantiate(gem, transform.position, Quaternion.identity);
		//Destroy(gameObject);
		gameObject.SetActive(false);
	}
}
