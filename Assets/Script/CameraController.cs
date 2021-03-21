using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private GameObject player;

    [SerializeField] private bool _firstCameraMode = true;

    // Store mouse location
    private float mouseVertical;
    private float mouseHorizontal;

    private void Start()
    {
        _offset = new Vector3(0,0,-1);
    }

    private void Update()
    {
        // get mouse 
        mouseHorizontal = Input.GetAxis("Mouse X");
        mouseVertical = Input.GetAxis("Mouse Y");


        if (_firstCameraMode)
        {
            transform.position = _target.position;

            // rotate camera
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, player.transform.eulerAngles.y, transform.eulerAngles.z);
            player.transform.Rotate(Vector3.up * mouseHorizontal * 10);
            transform.Rotate(Vector3.right * -mouseVertical * 10);
        }
        else
        {
            transform.position = _target.position + _offset;
        }

        if(Input.GetKeyDown(KeyCode.V))
        {
            _firstCameraMode = !_firstCameraMode;
        }
        
    }
}
