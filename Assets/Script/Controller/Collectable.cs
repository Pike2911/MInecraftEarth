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

        [SerializeField] string BlockType = "";

        float x = 0;
        float y = 0;
        float z = 0;
        private void OnTriggerEnter(Collider other)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<Player>().increaseBlock( BlockType );
            Destroy(gameObject);
        }
        private void FixedUpdate()
        {
            transform.rotation = Quaternion.Euler(x, y, z);

            x = x + speedx;
            y = y + speedy;
            z = z + speedz;
        }
    }

}
