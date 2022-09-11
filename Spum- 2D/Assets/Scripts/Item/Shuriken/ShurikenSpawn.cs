using System;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _shurikenPref; 
    [SerializeField] private float _length;
    [SerializeField] private float _showTime;
    [SerializeField] private float _offTime;
    
    private List<GameObject> _shurikens;
    private float _timer;
    private ItemState _state;

    public enum ItemState
    {
        Init,
        Running,
        Disable
    }

    private void Start()
    {
        transform.position = _player.transform.position;
        _shurikens = new List<GameObject>();
        _state = ItemState.Init;
        _timer = 0f;
    }

    private void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer <= 0)
        {
            switch (_state)                                            
            {                                                          
                case ItemState.Init:                                   
                    Init();                                            
                    SwitchState();                                        
                    return;                                            
                case ItemState.Running:                                
                    _timer = _showTime;                                
                    SwitchState();                                              
                    return;                                            
                case ItemState.Disable:
                    ClearShuriken();   
                    _timer = _offTime;                                          
                    SwitchState();                                                 
                    return;                                            
                                                            
                                                            
                                                            
            }                                                          
        }
        

    }

    private void SwitchState()
    {
        switch (_state)
        {
            case ItemState.Init:
                _state = ItemState.Running;
                return;
            case ItemState.Running:
                _state = ItemState.Disable;     
                return; 
            case ItemState.Disable:                    
                _state = ItemState.Init;            
                return;                                
        }
    }

    private void Init()
    {
        ClearShuriken(); 

        var myAngleInDegrees = 360 /Inventory.Instance.shuriken;
        
        for (int i = 0; i < Inventory.Instance.shuriken; i++)
        {
            var angle = myAngleInDegrees * i;
            var sinOfAngle = Mathf.Sin((angle * Mathf.PI)/180);
            var cosOfAngle = Mathf.Cos((angle * Mathf.PI)/180);
            var pos = _player.transform.position + new Vector3(cosOfAngle * _length, sinOfAngle * _length, 0);
            GameObject shuriken = Instantiate(_shurikenPref.gameObject, pos, Quaternion.identity, transform);
            _shurikens.Add(shuriken);
        }
    }

    private void ClearShuriken()
    {
        //reset shuriken                                            
        if (_shurikens.Count > 0)                                   
        {                                                           
            foreach (var shuriken in _shurikens)                    
            {                                                       
                Destroy(shuriken.gameObject);                       
            }                                                       
        }                                                           
    }

    public void AddShuriken()
    {
        Inventory.Instance.shuriken++;
        Init();
    }
        
}
