using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Color = UnityEngine.Color;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler
{
    private bool isDragging = false;
    private Vector3 offset;

    void Update()
    {
        if (isDragging)
        {
            transform.position = Input.mousePosition + offset;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isDragging = true;
        offset = transform.position - Input.mousePosition;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
    }

}
