using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPlayer : MonoBehaviour
{
    public GameObject fx;
    int currentHealth;

    public HPBar hPBar;
    public int health = 10;
    public Animator anm;
    
    private static readonly int Dead = Animator.StringToHash("dead");
    private static readonly int Hurt = Animator.StringToHash("hurt");
    
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
    private void Start()
    {
        currentHealth = health;
        hPBar.SetMaxHealth(health);
    }
    public void TakeDamage(int damage)
    {
        StartCoroutine(DamageAnimation());
        anm.SetBool(Hurt, true);
        currentHealth -= damage;
        Debug.Log("dameE");
        if (currentHealth <= 0)
        {
            Die();
        }
        Invoke(nameof(NoHurt),0.5f);
        hPBar.SetHealth(currentHealth);
    }
    void NoHurt()
    {
        anm.SetBool(Hurt ,false);
    }
    
    void Die()
    {
        Destroy(gameObject);
        Instantiate(fx, transform.position, Quaternion.identity);
        //anm.SetTrigger(Dead);
        //anm.SetBool(Hurt,false);
    }
    private void Destroy()
    {
        Destroy(gameObject);
    }
}
