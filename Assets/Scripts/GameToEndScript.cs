using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectEndScript : MonoBehaviour
{
    public GameObject triggerbox;
    private float strikes = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (triggerbox.CompareTag("Food"))
        {
            strikes += 1;
        }
        if (strikes >= 3)
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene(2);
        }
    }
}
