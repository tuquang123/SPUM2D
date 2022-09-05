using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    [SerializeField] private string _id;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void OnCollisionEnter2D(Collision2D col)
    {
        Collider2D colider = this.GetComponent<Collider2D>();
        col.collider.enabled = false;
        if(col.collider.gameObject.GetComponent<Drill>() != null)
        {
            if (_id == "X")
            {
                col.collider.gameObject.GetComponent<Drill>().FlipX();
            }
            if (_id == "Y")
            {
                col.collider.gameObject.GetComponent<Drill>().FlipY();
            }
        }     
        col.collider.enabled = true;
    }
}
