using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Destroy : MonoBehaviour
{
    private Camera mainCamera;
    private Renderer objectRenderer;
    private bool hasScored = false;
    void Start()
    {
        mainCamera = Camera.main;
        objectRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (!IsVisibleFrom(objectRenderer, mainCamera))
        {
            if (!hasScored)
            {
                ScoreManager.Instance.AddPoints(10); // Add points when the object goes off-screen
                hasScored = true; // Ensure points are added only once
            }
            Destroy(gameObject);
        }
    }

    // Helper function to check if the renderer is visible from the camera
    private bool IsVisibleFrom(Renderer renderer, Camera camera)
    {
        if (camera == null || renderer == null)
            return false;

        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
    }
    
    
}
