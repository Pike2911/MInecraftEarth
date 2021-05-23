using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PGME.Core;

namespace PGME.Controller
{
    public class Collectable : MonoBehaviour
    {
        [SerializeField] float speedx = 0f;
        [SerializeField] float speedy = 1f;
        [SerializeField] float speedz = 0f;

        float x = 0;
        float y = 0;
        float z = 0;
        private void OnTriggerEnter(Collider other)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<Player>().increaseBlock();
            Destroy(gameObject);
        }
        private void Update()
        {
            transform.rotation = Quaternion.Euler(x, y, z);

            x = x + speedx;
            y = y + speedy;
            z = z + speedz;
        }
    }

}
