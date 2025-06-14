using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private AudioSource _source;

    private void Start()
    {
        _source = GetComponent<AudioSource>();
        Debug.Log("Sconfiggi e nemici e raccogli le monete!");
    }
    void Update()
    {
        
        
        if (_target != null) 
        {
            Vector3 newPosition = _target.position; 

            newPosition.z = transform.position.z; 

            transform.position = newPosition; 
        }

        _source.Play();
    }

}
