using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class RotatingAround : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Transform _target;

    private void Start()
    {
        _target = GetComponent<Transform>();
    }

    private void Update()
    {
        _target.RotateAround(_target.position, _target.up, _speed * Time.deltaTime);
    }
}
