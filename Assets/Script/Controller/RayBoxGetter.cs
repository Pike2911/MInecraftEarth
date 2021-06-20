using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PGME.Scene;

namespace PGME.Controller
{
    public class RayBoxGetter : MonoBehaviour
    {
        [SerializeField] private GameObject Block = null;
        void Update()
        {
            int layerMask = 1 << 8;

            Debug.DrawRay(transform.position, Camera.main.transform.forward * 100, Color.red);

            if (Input.GetMouseButtonDown(1))
            {
                RaycastHit hit;
                Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

                if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
                {
                    if (hit.collider != null)
                    {
                        Vector3 loc = hit.point + hit.normal * 0.5f;
                        loc = new Vector3(Mathf.Round(loc.x), Mathf.Round(loc.y), Mathf.Round(loc.z));
                        if (!hit.collider.gameObject.CompareTag("Player"))
                        {
                            Instantiate(Block, loc, hit.collider.gameObject.transform.rotation);
                            //hit.collider.gameObject.GetComponent<Block>().TakeDamage();
                        }
                    }
                }
            }
        }
    }
}


