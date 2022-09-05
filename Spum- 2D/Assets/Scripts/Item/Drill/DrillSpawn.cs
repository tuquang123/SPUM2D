using System;
using System.Collections.Generic;
using UnityEngine;

public class DrillSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _drillPref;
    [SerializeField] private float _spawnTime;

    private List<GameObject> _drills;
    private float _timer;
    private void Start()
    {
        //transform.position = _player.transform.position;
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
        
        for (int i = 0; i < Inventory.Instance.drill; i++)
        { 
            GameObject drill = Instantiate(_drillPref.gameObject, transform.position, Quaternion.identity);
            _drills.Add(drill);
        }
    }
}