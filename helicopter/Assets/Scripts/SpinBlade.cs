using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinBlade : MonoBehaviour
{
    [SerializeField] private float _spinSpeed;
    const float MAX_SPIN = 100.0f;
    void Update()
    {
        Accelerate();
    }

    private void Accelerate()
    {
        if (Input.GetKey(KeyCode.Space) && _spinSpeed <= MAX_SPIN)
        {
            _spinSpeed += 5f;
        }

        if(_spinSpeed > MAX_SPIN)
        {
            _spinSpeed = MAX_SPIN;
        }

        Spin();
    }

    private void Spin()
    {
        transform.Rotate(Vector3.up * _spinSpeed * Time.deltaTime);
    }
}
