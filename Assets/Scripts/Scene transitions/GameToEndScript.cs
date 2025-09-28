using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectEndScript : MonoBehaviour
{
    public GameObject triggerbox;
    public float strikes = 0f;
    
    public GameObject Corn1;
    public GameObject Corn2;
    public GameObject Corn3;
    public GameObject DeadCorn1;
    public GameObject DeadCorn2;
    public GameObject DeadCorn3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (strikes == 0)
        {
            Corn1.gameObject.SetActive(true);
            Corn2.gameObject.SetActive(true);
            Corn3.gameObject.SetActive(true);
            DeadCorn1.gameObject.SetActive(false);
            DeadCorn2.gameObject.SetActive(false);
            DeadCorn3.gameObject.SetActive(false);
        }
        if (strikes == 1)
        {
            Corn1.gameObject.SetActive(false);
            DeadCorn1.gameObject.SetActive(true);
        }
        if (strikes == 2)
        {
            Corn2.gameObject.SetActive(false);
            DeadCorn2.gameObject.SetActive(true);
        }
        if (strikes == 3)
        {
            Corn3.gameObject.SetActive (false);
            DeadCorn3.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("message");
        if (collision.gameObject.CompareTag("Food"))
        {
            strikes += 1;
        }
        if (collision.gameObject.CompareTag("Christmas"))
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
