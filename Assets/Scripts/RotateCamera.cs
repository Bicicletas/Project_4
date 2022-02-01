using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 200f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //float horizontalInput = Input.GetAxis("Horizontal");
        float horizontalInputMouse = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * horizontalInputMouse);

    }
}
