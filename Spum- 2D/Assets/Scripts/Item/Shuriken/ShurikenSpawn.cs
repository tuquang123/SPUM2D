using System.Collections.Generic;
using UnityEngine;

public class ShurikenSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _shurikenPref; 
    [SerializeField] private float _length;

    private List<GameObject> shurikens;


    private void Start()
    {
        transform.position = _player.transform.position;
        shurikens = new List<GameObject>();
        Init();
    }

    private void Init()
    {
        //reset shuriken
        if (shurikens.Count > 0)
        {
            foreach (var shuriken in shurikens)
            {
                Destroy(shuriken.gameObject);
            }
        }

        var myAngleInDegrees = 360 /Inventory.Instance.suriken;
        
        for (int i = 0; i < Inventory.Instance.suriken; i++)
        {
            var angle = myAngleInDegrees * i;
            var sinOfAngle = Mathf.Sin((angle * Mathf.PI)/180);
            var cosOfAngle = Mathf.Cos((angle * Mathf.PI)/180);
            var pos = _player.transform.position + new Vector3(cosOfAngle * _length, sinOfAngle * _length, 0);
            GameObject shuriken = Instantiate(_shurikenPref.gameObject, pos, Quaternion.identity, transform);
            shurikens.Add(shuriken);
        }
    }

    public void AddShuriken()
    {
        Inventory.Instance.suriken++;
        Init();
    }
        
}
