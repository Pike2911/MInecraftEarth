using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PGME.Scene;
using PGME.Core;

namespace PGME.Controller
{
    public class RayBoxGetter : MonoBehaviour
    {
        [SerializeField] private GameObject Block = null;

        Player player;

        private void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        }

        void Update()
        {
            int layerMask = 1 << 8;

            Debug.DrawRay(transform.position, Camera.main.transform.forward * 100, Color.red);

            if (Input.GetMouseButtonDown(1))
            {
                // place block

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
                            if( player.GetComponent<Player>().dirt >= 20)
                            {
                                player.decreaseBlock();
                                Instantiate(Block, loc, hit.collider.gameObject.transform.rotation);
                            }
                        }
                    }
                }
            }
            else if( Input.GetMouseButtonDown(0))
            {
                // kill box

                RaycastHit hit;
                Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

                if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
                {
                    if (hit.collider != null)
                    {
                        if (!hit.collider.gameObject.CompareTag("Player"))
                        {
                            // TODO: Fix Hack
                            if(hit.collider.gameObject.GetComponent<Block>() != null)
                            {
                                hit.collider.gameObject.GetComponent<Block>().TakeDamage();
                            }
                        }
                    }
                }

            }
        }
    }
}


