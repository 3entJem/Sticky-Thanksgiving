using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Spawnerpt2 : MonoBehaviour
{
    public List<Wave> waves = new List<Wave>();
    float maxTimer = 1f;
    float timer = 1f;

    public GameObject point1;
    public GameObject point2;

    bool spawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        timer = waves[0].interval;
        maxTimer = waves[0].interval;
        

        
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            spawn = true;
        }
        else
        {
            spawn = false;
        }
        if (spawn)
        {
            Spawn();
        }

        // if (timer == 0f)
        // {
        //     // foreach (Wave wave in waves)
        //     // {
        //     //     Instantiate(wave.foodPrefab, ChooseSpawnPoint(), Quaternion.identity);
        //     // }
        //     timer = maxTimer;
        // }
        // //GameObject newFood = Instantiate(Food, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 0), 0), Quaternion.identity);


    }

    void Spawn()
    {
        for (int i = 1; i < waves.Count; i++)
        {
            if (timer <= 0f)
            {
                Instantiate(waves[i].foodPrefab, ChooseSpawnPoint(), Quaternion.identity);
                timer = waves[i].interval;
                i++;
            }
        }
    }

    public Vector2 ChooseSpawnPoint()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(point1.transform.position.x, point2.transform.position.x), Random.Range(point1.transform.position.y, point2.transform.position.y));
        return spawnPosition;
    }
}