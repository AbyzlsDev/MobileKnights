using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMeleeDamage : MonoBehaviour
{
   
    public Transform player;
    public Characters characters;
    int damage;
    public LayerMask layerMask;
    public Transform attackPoint;
    float nextTimeToShoot;
    float CPS;
    float AttackRange;
    UltimateMoves ults;
   




    void Start()
    {
        ults = GetComponent<UltimateMoves>();
        CPS = characters.CPS;
        AttackRange = characters.AttackRange;
        damage = characters.damage;
       
        
    }

    

    // Update is called once per frame
    void Update()
    {

        CPS = characters.CPS;
        AttackRange = characters.AttackRange;
        damage = characters.damage;

        if (Input.GetButtonDown("Fire1") && Time.time >= nextTimeToShoot) {

            nextTimeToShoot = Time.time + 1 / CPS;
            Shoot();

          
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {

            ults.TriggerUlt();


        }

    }
    void Shoot()
    {


        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(attackPoint.position, AttackRange, layerMask);
        foreach (Collider2D enemy in hitColliders)
        {
            enemy.GetComponent<Target>().TakeDamage(damage);

        }


    }
}
