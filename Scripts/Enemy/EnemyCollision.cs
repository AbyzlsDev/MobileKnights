
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public Characters enemy;
  void OnTriggerEnter2D(Collider2D collision)
    {

       collision.GetComponent<PlayerTakeDamage>().PlayerDamageTake(enemy.damage);
        
    }

}
