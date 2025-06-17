using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    private Transform _player;
    private EnemyAnimation _animator;

    void Start()
    {
        GameObject Object = GameObject.FindGameObjectWithTag("Player");

        if (Object != null)
        {
            _player = Object.transform;
        }

        _animator = GetComponent<EnemyAnimation>();
    }

    void Update()
    {
        if (_player != null)
        {
            Vector2 dir = (_player.position - transform.position).normalized;
            transform.position += (Vector3)(dir * _speed * Time.deltaTime);
            _animator.UpdateAnimation(dir);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LifeController life = collision.gameObject.GetComponent<LifeController>();
            if (life != null)
            {
                life.AddHp(-1);
                Debug.Log("Enemy si è autodistrutto. Player perde 1 HP");
            }
            Destroy(gameObject);
        }
    }
}