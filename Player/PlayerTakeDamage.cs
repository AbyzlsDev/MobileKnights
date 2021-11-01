using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDamage : MonoBehaviour
{
    public Characters characters;

    void Update()
    {
        if (characters.HP <= 0) {

            Destroy(gameObject);
        
        }
        
    }

   public void PlayerDamageTake(int damage) {


        characters.HP -= damage;
    
    
    }


}
