using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Mover2D _mover2D;
    void Start()
    {
        _mover2D = GetComponent<Mover2D>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(h, v);
        
        _mover2D.UpdateDirection(dir);
    }
}
