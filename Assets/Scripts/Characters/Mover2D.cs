using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover2D : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    private Rigidbody2D _rb;
    public Vector2 _direction { get; private set; }

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (_direction != Vector2.zero)
        {
            _rb.MovePosition(_rb.position + _direction * (_speed * Time.deltaTime));
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
