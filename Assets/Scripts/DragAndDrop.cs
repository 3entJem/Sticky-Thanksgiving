using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour
{

    void OnMouseDrag()
    {
        transform.position = GetMousePos();
    }

     Vector3 GetMousePos()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;
        return mousePos;

        
    }
}
