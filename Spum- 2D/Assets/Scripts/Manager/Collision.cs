using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    //collision 
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("speed"))
        {
            Inventory.Instance.speed++;
            Destroy(col.gameObject);
        }
        if (col.CompareTag("speedAttack"))
        {
            Inventory.Instance.speedAttack++;
            Destroy(col.gameObject);
        }
        if (col.CompareTag("drill"))
        {
            Inventory.Instance.drill++;
            Destroy(col.gameObject);
        }
        if (col.CompareTag("rocket2"))
        {
            Inventory.Instance.rocket2++;
            Destroy(col.gameObject);
        }
        if (col.CompareTag("shuriken"))
        {
            Inventory.Instance.shuriken++;
            Destroy(col.gameObject);
        }
        if (col.CompareTag("radiate"))
        {
            Inventory.Instance.radiate++;
            Destroy(col.gameObject);
        }
        if (col.CompareTag("speedAttackBasic"))
        {
            Inventory.Instance.speedAttackBasic++;
            Destroy(col.gameObject);
        }
        if (col.CompareTag("speedAttackThunder"))
        {
            Inventory.Instance.speedAttackThunder++;
            Destroy(col.gameObject);
        }
        if (col.CompareTag("AttackSpeedSaw"))
        {
            Inventory.Instance.attackSpeedSaw++;
            Destroy(col.gameObject);
        }
        if (col.CompareTag("boom"))
        {
            Inventory.Instance.boom++;
            Destroy(col.gameObject);
        }
        if (col.CompareTag("book"))
        {
            Inventory.Instance.book++;
            Destroy(col.gameObject);
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
