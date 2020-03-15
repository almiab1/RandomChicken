using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float mouseSensibility = 100f;
    public Transform playerBody;

    private float _xRotation = 0f;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {

        float moueseX = Input.GetAxis("Mouse X") * mouseSensibility * Time.deltaTime;
        float moueseY = Input.GetAxis("Mouse Y") * mouseSensibility * Time.deltaTime;

        _xRotation -= moueseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * moueseX);

    }
}
