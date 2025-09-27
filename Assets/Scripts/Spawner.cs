using UnityEngine;
using System.Collections;

public class Spanwer : MonoBehaviour
{
    [SerializeField] private GameObject ChristmasTree;
    [SerializeField] private GameObject Ham;
    [SerializeField] private GameObject PumpkinPie;    
    [SerializeField] private GameObject Cranberry;
    [SerializeField] private GameObject Dressing;
    [SerializeField] private GameObject BananaPudding;
    [SerializeField] private GameObject Turkey;


    [SerializeField] private float slowInterval = 10f;
    [SerializeField] private float normalInterval = 7f;
    [SerializeField] private float fastInterval = 5f;
    void Start()
    {
        StartCoroutine(spawnEnemy(slowInterval, ChristmasTree));
        StartCoroutine(spawnEnemy(normalInterval, Ham));
        StartCoroutine(spawnEnemy(fastInterval, PumpkinPie));
        StartCoroutine(spawnEnemy(slowInterval, Cranberry));
        StartCoroutine(spawnEnemy(normalInterval, Dressing));
        StartCoroutine(spawnEnemy(fastInterval, BananaPudding));
        StartCoroutine(spawnEnemy(slowInterval, Turkey));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        }
    }
}
