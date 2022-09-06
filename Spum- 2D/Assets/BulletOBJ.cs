using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOBJ : MonoBehaviour
{
    Vector2 movDir;
    public float speed;
    private void OnEnable()
    {
        Invoke("Destroy", 3f);
    }
    private void Start()
    {
        speed = 10f;
    }
    private void Update()
    {
        transform.Translate(movDir * speed * Time.deltaTime);
    }
    public void SetMoveDirection(Vector2 dir)
    {
        movDir = dir;
    }
    public void Destroy()
    {
        gameObject.SetActive(false);
    }
}
