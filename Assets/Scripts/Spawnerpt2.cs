using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Spawnerpt2 : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;

    [System.Serializable]
    public class SpawnableEnemy
    {
        public string name;
        public GameObject enemyPrefab;
        public int count;
        public float interval; // Time between spawns for this enemy type
    }

    [System.Serializable]
    public class Wave
    {
        public string waveName;
        public List<SpawnableEnemy> enemiesInWave = new List<SpawnableEnemy>();
    }

    public List<Wave> waves = new List<Wave>();
    public Transform[] spawnPoints;

    public float timeBetweenWaves = 5f;
    private int currentWaveIndex = 0;

    void Start()
    {
        StartCoroutine(RunWaves());
    }

    IEnumerator RunWaves()
    {
        while (currentWaveIndex < waves.Count)
        {
            Wave currentWave = waves[currentWaveIndex];
            Debug.Log($"Starting Wave {currentWaveIndex + 1}: {currentWave.waveName}");

            yield return StartCoroutine(SpawnWaveRandomized(currentWave));

            currentWaveIndex++;
            yield return new WaitForSeconds(timeBetweenWaves);
        }

        Debug.Log("All waves completed!");
    }

    IEnumerator SpawnWaveRandomized(Wave wave)
    {
        // Create a flat list of all enemies to spawn
        List<SpawnableEnemy> spawnQueue = new List<SpawnableEnemy>();

        foreach (var enemy in wave.enemiesInWave)
        {
            for (int i = 0; i < enemy.count; i++)
            {
                spawnQueue.Add(enemy);
            }
        }

        // Shuffle the list randomly
        Shuffle(spawnQueue);

        // Spawn enemies one by one from the randomized list
        foreach (var enemy in spawnQueue)
        {
            SpawnEnemy(enemy.enemyPrefab);
            yield return new WaitForSeconds(enemy.interval);
        }
    }

    void SpawnEnemy(GameObject prefab)
    {
        if (spawnPoints.Length == 0) return;

        Vector2 spawnPosition = new Vector2(Random.Range(point1.transform.position.x, point2.transform.position.x), Random.Range(point1.transform.position.y, point2.transform.position.y));
        Instantiate(prefab, spawnPosition, Quaternion.identity);
    }

    // Fisher–Yates shuffle
    void Shuffle<T>(List<T> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}