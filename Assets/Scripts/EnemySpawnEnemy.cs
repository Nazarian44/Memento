using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnEnemy : MonoBehaviour
{
    //[SerializeField] private uint maxEnemiesAmount;

    public GameObject enemy;
    public Transform[] spawnSpots;

    private float timeBtwSpawns;
    public float startTimeBtwSpawns;

    //private List<MemoryPickup> spawnedPickups = new List<MemoryPickup>();

    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }

    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            //this.InstantiateMemory();
            timeBtwSpawns = startTimeBtwSpawns;
            int randPos = Random.Range(0, spawnSpots.Length - 1);
            GameObject memory = Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }

   /* private void InstantiateMemory()
    {
        if (this.spawnedPickups.Count < this.maxEnemiesAmount)
        {
            int randPos = Random.Range(0, spawnSpots.Length - 1);
            GameObject memory = Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);

            // Get memory pickup script from game object
            MemoryPickup memoryPickup = memory.GetComponent<MemoryPickup>();

            // Add the instantiated object to the list in roder to know the amount if 
            // instantiated objects in the scene
            this.spawnedPickups.Add(memoryPickup);

            // When the object is destroyed, is removed from the list
            // When the object is destroyed, is removed from the list
            System.Action<MemoryPickup> onMemoryDestroyed = null;
            onMemoryDestroyed = (MemoryPickup pickup) =>
            {
                if (this.spawnedPickups.Contains(pickup))
                {
                    this.spawnedPickups.Remove(pickup);
                }

                pickup.onDestroyed -= onMemoryDestroyed;
            };

            //memoryPickup.onDestroyed += onMemoryDestroyed;
        }
    }*/
}
