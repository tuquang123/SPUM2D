using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public int minX, maxX;
    public int minY, maxY;

    public GameObject[] listItem;
    public float spawnTimer;

    private float randx, randy;
    Vector2 whereToSpawn;

    void Start()
    {
        StartCoroutine(SpawnPositionItem(listItem, spawnTimer));
    }

    private IEnumerator SpawnPositionItem(GameObject[] listItem, float spawnTimer)
    {
        yield return new WaitForSeconds(spawnTimer);
        randx = Random.Range(minX, maxX);
        randy = Random.Range(minY, maxY);
        whereToSpawn = new Vector2(randx, randy);
        var newItem = Instantiate(listItem[Random.Range(0, listItem.Length)], whereToSpawn, Quaternion.identity);
        StartCoroutine(SpawnPositionItem(listItem, spawnTimer));
    }
}
