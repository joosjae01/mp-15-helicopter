using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _helicopter;
    [SerializeField] private float _backPreset;
    [SerializeField] private float _heightPreset;
    private void Update()
    {
        ChaseHelicopter();
    }

    private void ChaseHelicopter()
    {
        transform.position = _helicopter.position;
        transform.rotation = _helicopter.rotation;
        transform.Translate(Vector3.forward * -_backPreset);
        transform.Translate(Vector3.up * _heightPreset);
    }
}
