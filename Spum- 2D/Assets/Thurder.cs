using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Thurder : MonoBehaviour
{
    public GameObject bullet;
    public int damage;
    private Vector3 targetPosition;
    public float speed;

    private void Start()
    {
        targetPosition = FindObjectOfType<HpEnemy>().transform.position;
    }
    private void Update()
    {
        transform.position =
            Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        if (targetPosition == transform.position)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            HpEnemy enemy = other.GetComponent<HpEnemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
                var bul = Instantiate(bullet, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}