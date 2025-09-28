using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public float scrollspeed = 0f; 
    private RectTransform rectTransform; 

    void Start()
    {
        Time.timeScale = 1f;
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
      rectTransform.anchoredPosition += new Vector2(0, scrollspeed * Time.deltaTime);  
    }
}
