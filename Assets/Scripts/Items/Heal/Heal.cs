using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private int _healAmount = 10;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.Play("heal");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.TryGetComponent<LifeController>(out LifeController life);
            life.AddHp(_healAmount);
            Debug.Log("Player recupera" + _healAmount + "HP!");
            Destroy(gameObject);
        }
    }
}
