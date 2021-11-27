
using UnityEngine;

public class EnemyBehaviorSwitch : MonoBehaviour
{
    
    EnemyMovement enemyMovement;

     void Start()
    {
        enemyMovement = GetComponent<EnemyMovement>();
        
    }
    
    private void FixedUpdate()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 2f, enemyMovement.layerMask);

        if (collider.Length > 0) {

            enemyMovement.hasDetectedPlayer = true;

        }


    }

    
}
