using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private Transform _mycamera;

    [SerializeField] private bool _FistCameraMode = true;

    private void Start()
    {
        _mycamera = transform;

    }
    private void Update()
    {
        transform.position = _target.position;

        if (_FistCameraMode)
        {
            transform.position = _target.position;
        }
        else
        {
            transform.position = _target.position - new Vector3(0.736f, -0.169f, 0.046f);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            _FistCameraMode = !_FistCameraMode;
        }
    }
}
