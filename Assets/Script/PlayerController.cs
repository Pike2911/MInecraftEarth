using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float jumpPower = 200.0f;

    private Vector3 playerPosition;
    private Transform objectTransform;

    private Rigidbody rigidbody;

    [SerializeField] Transform cam;

    private void Start()
    {
        objectTransform = GetComponent<Transform>();
        playerPosition = objectTransform.position;

        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {


    }

    private void FixedUpdate()
    {

        Move();
    }

    #region private methods

    private void Move()
    {

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 movement = speed * Camera.main.transform.forward;
            movement.y = 0.0f;
            rigidbody.AddForce(movement);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Vector3 movement = -speed * Camera.main.transform.forward;
            movement.y = 0.0f;
            rigidbody.AddForce(movement);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 movement = -speed * Camera.main.transform.right;
            movement.y = 0.0f;
            rigidbody.AddForce(movement);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Vector3 movement = speed * Camera.main.transform.right;
            movement.y = 0.0f;
            rigidbody.AddForce(movement);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(0.0f, jumpPower, 0.0f);
        }
    }

    #endregion
}
