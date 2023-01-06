using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take_Object : MonoBehaviour
{
    public int distance;
    public GameObject aim;
    
    void Update()
    {
       
    }

    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, distance))
        {
            Debug.Log("hello");
        }
    }

    private void OnMouseEnter()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, distance))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
    private void OnMouseExit()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, distance))
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }

}
