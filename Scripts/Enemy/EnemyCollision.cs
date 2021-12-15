
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public Characters enemy;
  
   void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerTakeDamage>().PlayerDamageTake(enemy.damage);
        }

    }
}
