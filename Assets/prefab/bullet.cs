
using UnityEngine;

public class bullet : MonoBehaviour
{
    void Start()
    {
        Invoke("DestroySelf", 2f);
    }

    void DestroySelf()
    {
        Destroy(gameObject);
    }

    // 일반 충돌
    void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();

        if (enemy != null)
        {
            Debug.Log("총알이 적에게 명중!");

            enemy.TakeDamage(20);

            Destroy(gameObject);
        }
    }

    // Trigger 충돌
    void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();

        if (enemy != null)
        {
            Debug.Log("총알이 적에게 명중!");

            enemy.TakeDamage(20);

            Destroy(gameObject);
        }
    }
}
