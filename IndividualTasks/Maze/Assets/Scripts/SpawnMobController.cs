using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMobController : MonoBehaviour
{
    public GameObject mobPrefab;
    public Transform[] spawnPoints;

    private bool hasSpawned = false;

    private void Start()
    {
        if (!hasSpawned)
        {
            SpawnMob();
            hasSpawned = true;
        }
        GameObject obj = GameObject.FindGameObjectWithTag("Mob");
        obj.SetActive(false);

    }

    private void SpawnMob()
    {
        int index = Random.Range(0, spawnPoints.Length);
        Instantiate(mobPrefab, spawnPoints[index].position, Quaternion.identity);
    }
}

