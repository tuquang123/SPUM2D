using System.Collections.Generic;
using UnityEngine;

public class DrillSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Drill _drillPref;
    private List<Drill> _drills;

    private void Start()
    {
        transform.position = _player.transform.position;
        _drills = new List<Drill>();
        
        Init();
                                
    }

    private void Init()
    {
        //reset drill list
        if (_drills.Count > 0)
        {
            foreach (var drill in _drills)
            {
                Destroy(drill.gameObject);
            }
        }
        _drills.Clear();
        
        for (int i = 0; i < Inventory.Instance.drill; i++)
        { 
            Drill drill = Instantiate(_drillPref, transform.position, Quaternion.identity, transform);
            _drills.Add(drill);
        }
    }
}