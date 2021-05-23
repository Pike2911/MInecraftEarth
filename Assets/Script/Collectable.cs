using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] float speedx;
    [SerializeField] float speedy;
    [SerializeField] float speedz;

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
        GetComponent<Transform>().rotation = Quaternion.Euler(x, y, z);

        x = x + speedx;
        y = y + speedy;
        z = z + speedz;
    }
}
