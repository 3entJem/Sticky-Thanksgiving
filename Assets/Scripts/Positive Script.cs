using UnityEngine;
using TMPro;

public class PositiveScript : MonoBehaviour
{
    public TextMeshProUGUI Lvtext;
    public GameObject LvColliders;
    public float Score = 0f;
    public float setamount = 1f;

    void Start()
    {
        Lvtext.text = Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            Score += setamount;
            Lvtext.text = Score.ToString();
        }
    }
}
