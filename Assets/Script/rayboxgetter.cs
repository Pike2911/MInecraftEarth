using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayboxgetter : MonoBehaviour
{
    void Update()
    {
        Debug.DrawRay(transform.position, Camera.main.transform.forward * 100, Color.green);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    if (!hit.collider.gameObject.CompareTag("Player") )
                    {
                        hit.collider.gameObject.GetComponent<Block>().TakeDamage();
                    }
                }
            }
        }
    }
}
