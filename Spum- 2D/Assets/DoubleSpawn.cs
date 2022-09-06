using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleSpawn : MonoBehaviour
{
    private float angle = 0f;
    private Vector2 bulletMove;
    public float rage = 0.1f; 
    private void Start()
    {
        InvokeRepeating("Fire", 0f, rage);
    }
    void Fire()
    {
        for(int i = 0; i <= 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin(((angle+180f*i) * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos(((angle+180f*i) * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bullet.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<BulletOBJ>().SetMoveDirection(bulDir);
        }
        angle += 10f;
        if(angle >= 360f)
        {
            angle = 0f;
        }
    }
}
