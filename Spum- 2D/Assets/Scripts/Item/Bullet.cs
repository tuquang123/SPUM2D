using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    public int damage;
    private Transform targetPosition;
    public float speed;
    
    private void Start()
    {
        //Destroy(gameObject, 3);
        targetPosition = FindTarget.instance.target;
        //targetPosition = FindObjectOfType<HpEnemy>().transform.position;
    }
    private void Update()
    {
        if (targetPosition == null) return;
        transform.position =
            Vector2.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);
        if(targetPosition.position == transform.position)
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
                Instantiate(bullet,transform.position,Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}