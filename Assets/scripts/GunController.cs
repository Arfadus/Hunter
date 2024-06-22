using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    public float sensor;
    private Vector3 initialRotation;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        initialRotation = transform.localEulerAngles;
    }
    void Update()
    {
        sensor = 5;
        horizontal = Input.GetAxis("Mouse X") * sensor;
        vertical = Input.GetAxis("Mouse Y") * sensor;
        Vector3 currentRotation = transform.eulerAngles;


        currentRotation.y += horizontal;
        currentRotation.x -= vertical;

        transform.eulerAngles = currentRotation;
    }
}
