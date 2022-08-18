using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    public Transform target;
    public float minimumDistance;
    [HideInInspector]public Vector3 targetDir;
    
    private void Turning()
    {
        if (target == null) return;
        //if (turnOff)
        {
            targetDir = target.position - transform.position;
            Transform charTrans = transform;
            charTrans.transform.localScale = new Vector3(Mathf.Sign(-targetDir.x), 1, 1);
        }
    }
    private void FixedUpdate()
    {
        Turning();
        FindTaget();
    }

    void FindTaget()
    {
        if (target)
        {
            if (Vector2.Distance(transform.position,target.position) > minimumDistance)//&& check.gg == false)
            {
                
                transform.position =
                    Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }
    }
    
}