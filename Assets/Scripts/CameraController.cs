using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _car;
    [SerializeField] private Vector3 _offset = new Vector3(0f,2f,-4f);
    [SerializeField] private float _speed = 10f;
    void FixedUpdate()
    {
        var targerPosition = _car.TransformPoint(_offset);
        transform.position = Vector3.Lerp(transform.position, targerPosition, _speed * Time.deltaTime);

        var direction = _car.position - transform.position;
        var rotation = Quaternion.LookRotation(direction, Vector3.up);

        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, _speed * Time.deltaTime);
    }
}
