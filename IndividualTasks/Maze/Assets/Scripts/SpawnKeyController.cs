using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKeyController : MonoBehaviour
{
    public GameObject keyPrefab;
    public Transform[] spawnPoints;

    private bool hasSpawned = false;

    private void Start()
    {
        if (!hasSpawned)
        {
            SpawnKey();
            hasSpawned = true;
        }
        GameObject obj = GameObject.FindGameObjectWithTag("key");
        obj.SetActive(false);

    }

    private void SpawnKey()
    {
        int index = Random.Range(0, spawnPoints.Length);
        Instantiate(keyPrefab, spawnPoints[index].position, Quaternion.identity);
    }
}
