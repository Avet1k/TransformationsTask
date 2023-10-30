using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growing : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private Transform _target;
    private Vector3 _scaleChange;
    
    private float _minY = 0.5f;
    private float _maxY = 1.5f;
    private float _converter = 1000;
    
    private void Start()
    {
        _target = GetComponent<Transform>();
        _scaleChange = new Vector3(_speed, _speed, _speed);
    }

    private void Update()
    {
        _target.transform.localScale += _scaleChange / _converter;

        if (_target.transform.localScale.y < _minY || _target.transform.localScale.y > _maxY)
            _scaleChange = -_scaleChange;
    }
}
