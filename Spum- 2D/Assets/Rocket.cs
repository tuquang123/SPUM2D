using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Rocket : MonoBehaviour
{
	public int dame;
	public Transform target;

	public float speed = 5f;
	public float rotateSpeed = 200f;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start()
	{
		target = FindTarget.instance.target;
		rb = GetComponent<Rigidbody2D>();
		//target = GameObject.FindGameObjectWithTag("Enemy").transform;
		Destroy(gameObject, 10f);
	}

	void FixedUpdate()
	{
		if (target == null) return;

		Vector2 direction = (Vector2)target.position - rb.position;

		direction.Normalize();

		float rotateAmount = Vector3.Cross(direction, transform.up).z;

		rb.angularVelocity = -rotateAmount * rotateSpeed;

		rb.velocity = transform.up * speed;
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Enemy"))
		{
			HpEnemy enemy = other.GetComponent<HpEnemy>();

			if (enemy != null)
			{
				enemy.TakeDamage(dame);
				//Instantiate(bullet, transform.position, Quaternion.identity);
				Destroy(gameObject);
			}
		}
	}
   
}