using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTarget : MonoBehaviour
{
    public static FindTarget instance;
    private void Awake()
    {
        instance = this;
    }
    public float attackRage = 20f;
    public Transform target;
    [HideInInspector] public float targetDis = Mathf.Infinity;
    [HideInInspector] public Vector3 targetDir;

    public void FixedUpdate()
    {
        //Turning();
        FindEnemy();
        IsTargetTooFar();
    }
    public virtual void FindEnemy()
    {
        //if (this.target== null) return;
        if (this.target) return;
        float dis;
        foreach (Transform obj in EnemyManager.instance.objects)
        {
            dis = Vector3.Distance(transform.position, obj.position);
            if (dis <= attackRage)
            {
                SetTaget(obj);
                return;
            }
        }
    }
    public void SetTaget(Transform target)
    {
        this.target = target;
        return;
    }
    public void IsTargetTooFar()
    {
        if (this.target == null) return;
        if (!this.target.gameObject.activeSelf)
        {
            this.target = null;
            return;
        }
        targetDis = Vector3.Distance(transform.position, this.target.position);
        if (targetDis > attackRage) target = null;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, attackRage);
    }
}
