using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinBlade : MonoBehaviour
{
    [SerializeField] private float _spinSpeed;
    const float MAX_SPIN = 1000.0f;
    void Update()
    {
        Accelerate();
    }

    public bool CanFly()
    {
        return _spinSpeed >= MAX_SPIN / 2;
    }

    private void Accelerate()
    {
        if (Input.GetKey(KeyCode.Space) && _spinSpeed <= MAX_SPIN)
        {
            _spinSpeed += 1f;
        } else if(Input.GetKey(KeyCode.LeftControl) && _spinSpeed > 0)
        {
            _spinSpeed -= 1f;
        }

        if(_spinSpeed > MAX_SPIN)
        {
            _spinSpeed = MAX_SPIN;
        }

        if(_spinSpeed <= 0)
        {
            _spinSpeed = 0f;
        }

        Spin();
    }

    private void Spin()
    {
        transform.Rotate(Vector3.up * _spinSpeed * Time.deltaTime);
    }
}
