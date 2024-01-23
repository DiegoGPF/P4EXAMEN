using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform cameraHolder;
    float verticallookRotation;

    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X"));
        verticallookRotation -= Input.GetAxis("Mouse Y");
        verticallookRotation = Mathf.Clamp(verticallookRotation, -90f, 90f);
        cameraHolder.localEulerAngles = new Vector3(verticallookRotation, 0, 0);
    }
}
