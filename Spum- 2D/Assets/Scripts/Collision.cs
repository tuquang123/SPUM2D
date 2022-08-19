using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    //collision 
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Gem"))
        {
            Destroy(col.gameObject);
            LevelPlayer lv = GetComponent<LevelPlayer>();
            lv.exp++;
        }
        if (col.CompareTag("Gold"))
        {
            Destroy(col.gameObject);
            Inventory.Instance.gold++;
        }
        if (col.CompareTag("Hp"))
        {
            Destroy(col.gameObject);
            HpPlayer hp = GetComponent<HpPlayer>();
            hp.currentHealth++;
        }
    }
}
