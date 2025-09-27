using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DragAndDrop : MonoBehaviour
{
    private bool dragging = false;
    private Vector3 offset;

    void Update()
    {
        if (dragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, offset.z));
            
        }
    }
    
    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.WorldToScreenPoint(transform.position).z));
        dragging = true;
    }
    private void OnMouseUp()
    {
        dragging = false;
    }
}

   
