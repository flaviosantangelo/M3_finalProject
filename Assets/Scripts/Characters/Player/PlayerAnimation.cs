using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
     private Animator _anim;
     private string _lastDirection = "player2_idle_front";
     private LifeController _lifeController;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _lifeController = GetComponent<LifeController>();
    }

    private void Update()
    {
     
    
        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && Input.GetKey(KeyCode.Space))
        {
            _anim.Play("player_run_back");
            _lastDirection = "player2_idle_back";
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            _anim.Play("player2_walk_back");
            _lastDirection = "player2_idle_back";
        }

        if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) && Input.GetKey(KeyCode.Space))
        {
            _anim.Play("player2_run_front");
            _lastDirection = "player2_idle_front";
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            _anim.Play("player2_walk_front");
            _lastDirection = "player2_idle_front";
        }

        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && Input.GetKey(KeyCode.Space))
        {
            _anim.Play("player2_run_left");
            _lastDirection = "player2_idle_left";
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            _anim.Play("player2_walk_left");
            _lastDirection = "player2_idle_left";
        }

        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && Input.GetKey(KeyCode.Space))
        {
            _anim.Play("player2_run_right");
            _lastDirection = "player2_idle_right";
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            _anim.Play("player2_walk_right");
            _lastDirection = "player2_idle_right";
        }
       
        if (!Input.anyKey)
        {
            _anim.Play(_lastDirection);
        }
       

    }
}

       


    


