using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour
{
    [SerializeField] private int _damage = 3;
    [SerializeField] private float _speed = 5;
    [SerializeField] private float _lifeSpan = 5;
    void Start()
    {
        Destroy(gameObject, _lifeSpan);
    }

    public void Shoot(Vector3 origin, Vector3 direction)
    {
        transform.position = origin;
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        Vector2 dir = direction;
        float sqrLength = dir.sqrMagnitude;
        if (sqrLength > 1)
        {
            dir /= Mathf.Sqrt(sqrLength);
        }
        rb.velocity = dir * _speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.collider.TryGetComponent<LifeController>(out LifeController life);
        
           
            life.TakeDamage(_damage);
            Debug.Log("Enemy subisce" + _damage + "danni!");
        }
        Destroy(gameObject); 
    }
}
