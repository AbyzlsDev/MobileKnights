using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOnHit : MonoBehaviour
{
    
 
    public AssultRifle shootingScirpt;

   
    // Start is called before the first frame update
   

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        


        if (collision) {

            Target target = collision.GetComponent<Target>();


            if (target != null) {

                target.TakeDamage(shootingScirpt.damage);
                Destroy(gameObject);

            }

        }
    }

}
