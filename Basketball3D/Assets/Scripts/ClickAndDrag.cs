using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ClickAndDrag : MonoBehaviour
{
    public GameObject selectedObject;
    Vector3 offset = -new Vector3(0f, 0.5f, -2f);

    private void Start()
    {
        selectedObject.transform.position = new Vector3(0.02f, 0.44f, -7.49f);
    }
    void Update()
    {
        //Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
        //    //Debug.Log(offset + " 1 23");
        //    if (targetObject)
        //    {
        //        selectedObject = targetObject.transform.gameObject;
        //        offset = selectedObject.transform.position - mousePosition;
        //        //Debug.Log("Inside");
        //    }
        //}
        //if (selectedObject)
        //{
        //    selectedObject.transform.position = mousePosition + offset;
        //    Debug.Log(offset + " 1 23");
        //}
        //if (Input.GetMouseButtonUp(0) && selectedObject)
        //{
        //    Debug.Log("Outside");
        //    selectedObject = null;
        //}
    }
}