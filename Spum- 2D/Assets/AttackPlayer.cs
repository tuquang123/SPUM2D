using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    public Animator anm;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anm.SetTrigger("att");
        }
    }
}
