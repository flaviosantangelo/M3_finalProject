using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{

    [SerializeField] private int _currentHp = 20;
    [SerializeField] private int _maxHp = 20;
    private bool _setMaxHp = true;
  
    public int GetHp() => _currentHp;
    public int GetMaxHp() => _maxHp;

    private void Start()
    {
        if (_setMaxHp)
        {
            SetHp(_maxHp);
        }
    }

    public void AddHp(int amount)
    {
        SetHp(_currentHp + amount);
    }

    public void TakeDamage(int damage)
    {
        _currentHp -= damage;
        if (_currentHp <= 0)
        {
            Debug.Log("Enemy è stato sconfitto!");
            Destroy(gameObject);
        }
    }
    
    public void SetHp(int hp)
    {
        hp = Mathf.Clamp(hp, 0, _maxHp);
        _currentHp = hp;

        if (_currentHp == 0)
        {
           Destroy(gameObject);
        }

    }
    public void SetMaxHp(int maxHp)
    {
        _maxHp = Mathf.Max(1, maxHp);
        SetHp(_currentHp);
    }    
}
