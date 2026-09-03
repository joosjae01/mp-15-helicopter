using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliMovement : MonoBehaviour
{
    [SerializeField] private float _heliSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] public SpinBlade HeliBlade;
    void Update()
    {
        Vector3 direction = GetDirection();
        HeliRotate(direction);
        Move(direction);
    }

    private void Move(Vector3 direction)
    {
        if (Input.GetKey(KeyCode.Space) && direction.y <= 500 && HeliBlade.CanFly())
        {
            direction.y += 1f;
        }

        if (Input.GetKey(KeyCode.LeftShift) && direction.y >= 0)
        {
            direction.y -= 1f;

        }

        transform.Translate(0, direction.y * _heliSpeed * Time.deltaTime, direction.z * _heliSpeed * Time.deltaTime);
    }

    private void HeliRotate(Vector3 direction)
    {
        if (direction == Vector3.zero) return;
        transform.Rotate(0, direction.x * _rotateSpeed* Time.deltaTime, 0);
    }

    private Vector3 GetDirection()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, Vertical);
        return direction.normalized;
    }
}
