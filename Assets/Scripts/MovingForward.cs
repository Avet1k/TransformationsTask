using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class MovingForward : MonoBehaviour
{
    private Vector3 _startPosition;
    private Vector3 _endPosition;
    private Transform _target;
    private float _endShiftZ = 3f;
    private float _tolerance = 0.00005f;

    private float _pathTime = 2;
    private float _pathRunningTime;
    
    private void Start()
    {
        _target = GetComponent<Transform>();
        _startPosition = _target.position;

        _endPosition = new Vector3(_startPosition.x, _startPosition.y, _startPosition.z + _endShiftZ);
    }

    private void Update()
    {
        _pathRunningTime += Time.deltaTime;
        _target.position = Vector3.Lerp(_startPosition, _endPosition, _pathRunningTime / _pathTime);

        if (Math.Abs(_endPosition.z - _target.position.z) < _tolerance)
        {
            (_endPosition, _startPosition) = (_startPosition, _endPosition);
            _pathRunningTime = 0;
        }
    }
}
