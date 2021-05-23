using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PGME.Scene;

namespace PGME.Controller
{
    public class RayBoxGetter : MonoBehaviour
    {
        void Update()
        {
            int layerMask = 1 << 8;

            Debug.DrawRay(transform.position, Camera.main.transform.forward * 100, Color.red);

            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

                if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
                {
                    if (hit.collider != null)
                    {
                        if (!hit.collider.gameObject.CompareTag("Player"))
                        {

                            hit.collider.gameObject.GetComponent<Block>().TakeDamage();
                        }
                    }
                }
            }
        }
    }
}


