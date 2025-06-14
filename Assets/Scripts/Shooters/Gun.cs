using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Shooter
{
    private Camera _cam;
    [SerializeField] private int _damage;
    
    private void Awake()
    {
        _cam = Camera.main;
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && ShootOrNot())
        {
            Vector3 screenPos = Input.mousePosition;
            screenPos.z = _cam.nearClipPlane;
            Vector3 worldPos = _cam.ScreenToWorldPoint(screenPos);
            Vector3 shootDirection = worldPos - transform.position;
            Shoot(transform.position, shootDirection);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.GetComponent<LifeController>()) 
        {
            LifeController lifeController = collision.gameObject.GetComponent<LifeController>();
            lifeController.TakeDamage(_damage); 
        }
        Destroy(gameObject);
    }

}


