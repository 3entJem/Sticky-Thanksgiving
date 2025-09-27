using UnityEngine;

public class GradientScript : MonoBehaviour
{
    public bool startTransitioning = false;
    public SpriteRenderer sr;
    

    // Update is called once per frame
    void Update()
    {
        if (startTransitioning == true && sr.color.a > 0f)
        {
            sr.color = new Vector4(sr.color.r, sr.color.g, sr.color.b, Mathf.Clamp((sr.color.a - 1f * Time.deltaTime), 0f, 1f));
        }
    }
}
