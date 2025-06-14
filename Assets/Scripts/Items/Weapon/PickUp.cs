using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private GameObject _weaponPrefab;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Transform player = collision.transform;
            GameObject weapon = Instantiate(_weaponPrefab, player.position, Quaternion.identity);
            weapon.GetComponent<SpriteRenderer>().enabled = false;
            weapon.transform.SetParent(player);
            Debug.Log("Arma Equipaggiata");
            Destroy(gameObject); 
        }
    }
}
