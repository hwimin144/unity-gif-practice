


using UnityEngine;

public class Player : MonoBehaviour
{
    float health = 100f;

    public void TakeDamage(int value)
    {
        health -= value;

        Debug.Log("Player Health : " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("Player Dead!");
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.HitPlayer(this);
        }
    }
}
