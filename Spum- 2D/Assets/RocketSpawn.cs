using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _drillPref;
    [SerializeField] private float _spawnTime;

    private List<GameObject> _drills;
    private float _timer;
    private void Start()
    {
        _drills = new List<GameObject>();
    }

    private void Update()
    {
        if (_timer <= 0)
        {
            Spawn();
            _timer = _spawnTime;
        }
        _timer -= Time.deltaTime;
        
    }

    private void Spawn()
    {
        _drills.Clear();
        
        for (int i = 0; i < Inventory.Instance.rocket2; i++)
        { 
            GameObject drill = Instantiate(_drillPref.gameObject, transform.position, Quaternion.identity);
            _drills.Add(drill);
        }
    }
}
