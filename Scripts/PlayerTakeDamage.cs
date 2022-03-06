using UnityEngine;

public class PlayerTakeDamage : MonoBehaviour
{
    public PlayerControler playerControler;

    void Update()
    {
       
        
    }

   public void PlayerDamageTake(int damage) {


       playerControler.HP -= damage;
    
    
    }


}
