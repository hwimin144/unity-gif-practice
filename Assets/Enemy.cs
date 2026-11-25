




using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 50f;

    // 총알에 맞았을 때 체력 감소
    public void TakeDamage(int value)
    {
        health -= value;

        Debug.Log(gameObject.name + " Health : " + health);

        if (health <= 0)
        {
            Debug.Log(gameObject.name + " Dead!");
            Destroy(gameObject);
        }
    }

    public float GetHealth()
    {
        return health;
    }

    // 플레이어와 충돌했을 때
    public virtual void HitPlayer(Player player)
    {
        player.TakeDamage(20);
        Destroy(gameObject);
    }
}
