using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public float spawnPosZ;
    public GameObject[] enemies;
    private float startDelay = 2f;
    [SerializeField, Range(0.1f, 3f)]
    private float spawnInterval = 1.5f;
    private int animalIndex = 0;

    void Start()
    {
        spawnPosZ = this.transform.position.z;
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval);
    }
    
    private void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, enemies.Length);
        Instantiate(enemies[animalIndex], new Vector3(Random.Range(-10,10),0,spawnPosZ)
                ,enemies[animalIndex].transform.rotation);
    }
}
