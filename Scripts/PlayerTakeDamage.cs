using UnityEngine;

public class PlayerTakeDamage : MonoBehaviour
{
    public PlayerControler playerControler;
    
    public void PlayerDamageTake(int damage) {


       playerControler.HP -= damage;
    
    
    }


}
