using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void UpdateAnimation(Vector2 dir)
    {
        if (Mathf.Abs(dir.x) > Mathf.Abs(dir.y))
        {
            if (dir.x > 0)
                _animator.Play("enemy_walk_right"); 
            else
                _animator.Play("enemy_walk_left"); 
        }
        else
        {
            if (dir.y > 0)
                _animator.Play("enemy_walk_down"); 
            else
                _animator.Play("enemy_walk_front"); 
        }
    
    }   
}
