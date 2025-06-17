using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover2D : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    [SerializeField] private float _runSpeed = 12;
    [SerializeField] private float _currentSpeed;
    private Rigidbody2D _rb;
    public Vector2 _direction { get; private set; }

    void Start()
    {
        _currentSpeed = _speed;
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _currentSpeed = Input.GetKey(KeyCode.Space) ? _runSpeed : _speed;
        if (_direction != Vector2.zero)
        {
            _rb.MovePosition(_rb.position + _direction * (_currentSpeed * Time.deltaTime));
        }
       
    }

    public void UpdateDirection(Vector2 direction)
    {
        float sqrLength = direction.sqrMagnitude;
        if (sqrLength > 1)
        {
            direction /= Mathf.Sqrt(sqrLength);
        }
        _direction = direction;
    }
}
