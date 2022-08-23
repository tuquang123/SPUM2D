using System;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using Random = UnityEngine.Random;

public class Drill : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _duration = 3f;
    private Vector2 _currentDirection = new Vector2(0,0);
    
    private void Start()
    {
        CalculateDirection();
        Destroy(this.gameObject,_duration);
    }
    

    private void Update()
    {
        transform.Translate(_currentDirection * _speed * Time.deltaTime);
    }
    
    private void CalculateDirection()
    {
        Vector2 randomVector2 = new Vector2(Random.value, Random.value);
        _currentDirection = randomVector2.normalized;
        
    }

    public void FlipX()
    {
        _currentDirection = new Vector2(-_currentDirection.x, _currentDirection.y);
    }
    
    public void FlipY()
    {
        _currentDirection = new Vector2(_currentDirection.x, -_currentDirection.y);
    }
}
