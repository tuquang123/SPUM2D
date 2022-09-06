using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public static BulletPool bullet;
    public GameObject poolBullet;
    private bool notEnoghtBullet = true;
    private List<GameObject> bullets;
    private void Awake()
    {
        bullet = this;
    }
    private void Start()
    {
        bullets = new List<GameObject>();
    }
    public GameObject GetBullet()
    {
        if(bullets.Count > 0)
        {
            for(int i = 0; i < bullets.Count; i++)
            {
                if (!bullets[i].activeInHierarchy)
                {
                    return bullets[i];
                }
            }
        }
        if (notEnoghtBullet)
        {
            GameObject bull = Instantiate(poolBullet);
            bull.SetActive(false);
            bullets.Add(bull);
            return bull;
        }
        return null;
    }
}
