using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyManager : MonoBehaviour
{
    public int minX, maxX;
    public int minY, maxY;

    public GameObject[] listEnemy;
    public float spawnRate;

    public GameObject[] listBoss;
    public float bossSpawnRate;

    public LevelPlayer LevelPlayer;

    private float randx, randy;
    Vector2 whereToSpawn;

    public static EnemyManager instance;
    public List<Transform> objects = new List<Transform>();
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    void RemoveList()
    {
        for (int i = 0; i < objects.Count; i++)
        {
            Transform obj = this.objects[i];
            if (obj.gameObject.activeSelf) continue;
            objects.Remove(obj);
        }
    }
    private void LateUpdate()
    {
        RemoveList();
    }
    void Start()
    {
        StartCoroutine(SpawnPositionEnemy(listEnemy, spawnRate));
        StartCoroutine(SpawnPositionEnemy(listBoss, bossSpawnRate));
    }

    private IEnumerator SpawnPositionEnemy(GameObject[] listBoth, float spawnRate)
    {
        yield return new WaitForSeconds(spawnRate);
        randx = Random.Range(minX, maxX);
        randy = Random.Range(minY, maxY);
        whereToSpawn = new Vector2(randx, randy);
        var newEnemy = Instantiate(listBoth[0], whereToSpawn, Quaternion.identity);
        StartCoroutine(SpawnPositionEnemy(listBoth, spawnRate));
        //SpawnEnemy();
        objects.Add(newEnemy.transform);
        
    }

    /*void SpawnEnemy()
    {
        if (LevelPlayer.level >= 2)
        {
            spawnRate = 1f;
            var newEnemy = Instantiate(listEnemy[Random.Range(0, 2)], whereToSpawn, Quaternion.identity, transform);
            objects.Add(newEnemy.transform);
        }
        if (LevelPlayer.level >= 3)
        {
            var newEnemy = Instantiate(listEnemy[Random.Range(0, 3)], whereToSpawn, Quaternion.identity,transform);
            objects.Add(newEnemy.transform);
        }
        if (LevelPlayer.level >= 4)
        {
            spawnRate = 0.9f;
            var newEnemy = Instantiate(listEnemy[Random.Range(0, 4)], whereToSpawn, Quaternion.identity,transform);
            objects.Add(newEnemy.transform);
        }
        if (LevelPlayer.level >= 5)
        {
            var newEnemy = Instantiate(listEnemy[Random.Range(1, 5)], whereToSpawn, Quaternion.identity,transform);
        }
        if (LevelPlayer.level >= 6)
        {
            spawnRate = 0.8f;
            var newEnemy = Instantiate(listEnemy[Random.Range(1, 6)], whereToSpawn, Quaternion.identity, transform);
            objects.Add(newEnemy.transform);
        }
        if (LevelPlayer.level >= 7)
        {
            var newEnemy = Instantiate(listEnemy[Random.Range(2, 7)], whereToSpawn, Quaternion.identity, transform);
            objects.Add(newEnemy.transform);
        }
        if (LevelPlayer.level >= 8)
        {
            spawnRate = 1.5f;
            var newEnemy = Instantiate(listEnemy[Random.Range(3, listEnemy.Length)], whereToSpawn, Quaternion.identity, transform);
            objects.Add(newEnemy.transform);
        }
    }*/
}
