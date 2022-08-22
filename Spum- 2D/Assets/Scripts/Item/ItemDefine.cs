using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Item", menuName = "Item")]
public class ItemDefine : ScriptableObject
{
    public string name;
    public string description;
    public int level;
    public Sprite sprite;
}
