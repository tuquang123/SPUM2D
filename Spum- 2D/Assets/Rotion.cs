using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rotion : MonoBehaviour
{
    public int rotateZ = 20;
    void FixedUpdate()
    {
        transform.Rotate(0,0,-rotateZ);
    }
}
