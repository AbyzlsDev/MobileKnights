using UnityEngine;

public class PlayerTakeDamage : MonoBehaviour
{
    public Characters characters;

    void Update()
    {
       
        
    }

   public void PlayerDamageTake(int damage) {


        characters.HP -= damage;
    
    
    }


}
