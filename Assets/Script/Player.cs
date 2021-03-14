using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 0.20f;
    [SerializeField] private float jump = 3.0f;

    private Vector3 PlayerPosition;
    private Transform PlayerMovement;
    private Rigidbody physical;
    private void Start()
    {
        PlayerMovement = GetComponent<Transform>();
        physical = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Movement();
    }
    private void Movement()
    {
        {
            if (Input.GetKey(KeyCode.W))
            {
                physical.AddForce(speed, 0.0f, 0.0f);
                Debug.Log(speed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                physical.AddForce(-speed, 0.0f, 0.0f);
            }
            if (Input.GetKey(KeyCode.A))
            {
                physical.AddForce(0.0f, 0.0f, speed);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                physical.AddForce(0.0f, 0.0f, -speed);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                physical.AddForce(0.0f, jump, 0.0f);
            }
        }
    }
}

