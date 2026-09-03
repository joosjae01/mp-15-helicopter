using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _helicopter;
    private void Update()
    {
        ChaseHelicopter();
    }

    private void ChaseHelicopter()
    {
        transform.position = _helicopter.position;
        transform.rotation = _helicopter.rotation;
        transform.Translate(Vector3.forward * -3);
        transform.Translate(Vector3.up * 1.5f);
    }
}
