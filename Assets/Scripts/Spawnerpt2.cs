using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Spawnerpt2 : MonoBehaviour
{
    public GameObject Food;
    public float timetoSpawn, spawnCountdown;

    public GameObject Food2;
    public float timetoSpawn2, spawnCountdown2;

    public GameObject Food3;
    public float timetoSpawn3, spawnCountdown3;
    public GameObject Food4;
    public float timetoSpawn4, spawnCountdown4;
    public GameObject Food5;
    public float timetoSpawn5, spawnCountdown5;
    public GameObject Food6;
    public float timetoSpawn6, spawnCountdown6;
    public GameObject Food7;
    public float timetoSpawn7, spawnCountdown7;
    public GameObject Food8;
    public float timetoSpawn8, spawnCountdown8;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnCountdown = timetoSpawn;
        spawnCountdown2 = timetoSpawn2;
        spawnCountdown3 = timetoSpawn3;
        spawnCountdown4 = timetoSpawn4;
        spawnCountdown5 = timetoSpawn5;
        spawnCountdown6 = timetoSpawn6;
        spawnCountdown7 = timetoSpawn7;
        spawnCountdown8 = timetoSpawn8;
    }

    // Update is called once per frame
    void Update()
    {

        spawnCountdown -= Time.deltaTime;
        if (spawnCountdown <= 0)
        {
            SpawnFood();
            spawnCountdown = timetoSpawn;

        }
        spawnCountdown2 -= Time.deltaTime;
        if (spawnCountdown2 <= 0)
        {
            Instantiate(Food2, transform.position, transform.rotation);
            spawnCountdown2 = timetoSpawn2;

        }
        spawnCountdown3 -= Time.deltaTime;
        if (spawnCountdown3 <= 0)
        {
            Instantiate(Food3, transform.position, transform.rotation);
            spawnCountdown3 = timetoSpawn3;

        }
        spawnCountdown4 -= Time.deltaTime;
        if (spawnCountdown4 <= 0)
        {
            Instantiate(Food4, transform.position, transform.rotation);
            spawnCountdown4 = timetoSpawn4;

        }
        spawnCountdown5 -= Time.deltaTime;
        if (spawnCountdown5 <= 0)
        {
            Instantiate(Food5, transform.position, transform.rotation);
            spawnCountdown5 = timetoSpawn5;

        }
        spawnCountdown6 -= Time.deltaTime;
        if (spawnCountdown6 <= 0)
        {
            Instantiate(Food6, transform.position, transform.rotation);
            spawnCountdown6 = timetoSpawn6;

        }
        spawnCountdown7 -= Time.deltaTime;
        if (spawnCountdown7 <= 0)
        {
            Instantiate(Food7, transform.position, transform.rotation);
            spawnCountdown7 = timetoSpawn7;

        }
        spawnCountdown8 -= Time.deltaTime;
        if (spawnCountdown8 <= 0)
        {
            Instantiate(Food8, transform.position, transform.rotation);
            spawnCountdown8 = timetoSpawn8;

        }

    }

    void SpawnFood()
    {
        
        Instantiate(Food, transform.position, transform.rotation);
        Instantiate(Food2, transform.position, transform.rotation);
        Instantiate(Food3, transform.position, transform.rotation);
        Instantiate(Food4, transform.position, transform.rotation);
        Instantiate(Food5, transform.position, transform.rotation);
        Instantiate(Food6, transform.position, transform.rotation);
        Instantiate(Food7, transform.position, transform.rotation);
        Instantiate(Food8, transform.position, transform.rotation);
        
        GameObject newFood = Instantiate(Food, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
      



    }
}