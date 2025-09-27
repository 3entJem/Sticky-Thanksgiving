using UnityEngine;

public class ChristmasScript : MonoBehaviour
{
    public GameObject SideColliders;
    public ObjectEndScript objectscript;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision )
    {
        if (SideColliders.CompareTag("Christmas"))
        {
           
        }
    }
}
