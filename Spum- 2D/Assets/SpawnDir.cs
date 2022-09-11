using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDir : MonoBehaviour
{
    //public int number;
    public GameObject bulletPref;
    //Vector2 transform;

    public float radius, mospeed;
    public float attackRate = 1f;
    float nextAttackTime = 0f;

    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            nextAttackTime = Time.time + 1f / attackRate;
            if (Inventory.Instance.radiate >= 1)
            {
                Spawn(Inventory.Instance.radiate + 1);
            }
        }

    }
    void Spawn(int number)
    {
        float angleStep = 360 / number;
        float angle = 0f;
        for (int i = 0; i <= number - 1; i++)
        {
            float DirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180) * radius;
            float DirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180) * radius;

            Vector3 vec3 = new Vector3(DirX, DirY,0f);
            Vector2 moveDir = (vec3 - transform.position).normalized*mospeed;

            var proj = Instantiate(bulletPref, transform.position, Quaternion.identity);
            proj.GetComponent<Rigidbody2D>().velocity =
                new Vector2(moveDir.x, moveDir.y);
            angle += angleStep;
        }
    }
}
