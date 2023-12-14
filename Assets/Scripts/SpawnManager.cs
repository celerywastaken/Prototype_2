using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 15;
    private float spawnPosZ = 15;
    private float spawnRangeZ = 15;
    private float spawnPosX = -15;
    private AnimalDirection animalDirection;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay,spawnInterval);
    }



    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    SpawnRandomAnimal();
        //}
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos;

        if (animalPrefabs[animalIndex].GetComponent<MoveForwardFood>() != null)
        {
            spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        }
        else if (animalPrefabs[animalIndex].GetComponent<ChickenLeft>() != null)
        {
            spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        }
        else
        {
            spawnPos = Vector3.zero;
        }
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    //private void SpawnRandomAnimal2()
    //{
    //    Vector3 spawnPos = new Vector3(spawnPosX,0,Random.Range(-spawnRangeZ, spawnRangeZ));
    //    int animalIndex = Random.Range(0, animalPrefabs.Length);
    //    Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    //}
}
