using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shooter : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private float _fireRate = 0.5f;
    private float _shotTime = 0;


    public bool ShootOrNot()
    {
        return Time.time - _shotTime >= _fireRate;
    }

    public void TryShoot(Vector3 position, Vector3 direction)
    {
        if (!ShootOrNot()) return;

        Shoot(position, direction);
    }


    public void Shoot(Vector3 position, Vector3 direction)
    {
        _shotTime = Time.time;

        Bullet cloneBullet = Instantiate(_bulletPrefab);
        cloneBullet.Shoot(position, direction);
        
    }

}
