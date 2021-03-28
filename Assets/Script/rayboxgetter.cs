using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayboxgetter : MonoBehaviour
{
    void Update()
    {
        Debug.DrawRay(transform.position, Camera.main.ScreenPointToRay(Input.mousePosition).direction * 100, Color.green);
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    hit.collider.gameObject.SetActive(false);
                    Debug.Log("slkdfjd");
                }
            }
        }
    }
}
