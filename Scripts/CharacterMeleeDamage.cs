using UnityEngine;

public class CharacterMeleeDamage : MonoBehaviour
{
   
    public Transform player;
    public Characters characters;
    int damage;
    public LayerMask layerMask;
    public Transform attackPoint;
    float AttackRange;
    UltimateMoves ults;
   




    void Start()
    {
        ults = GetComponent<UltimateMoves>();
        AttackRange = characters.AttackRange;
        damage = characters.damage;
       
        
    }

    

    // Update is called once per frame
    void Update()
    {

        AttackRange = characters.AttackRange;
        damage = characters.damage;


        if (Input.GetKeyDown(KeyCode.Q))
        {

            ultTrigger();


        }

    }
    public void Shoot()
    {


        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(attackPoint.position, AttackRange, layerMask);
        foreach (Collider2D enemy in hitColliders)
        {
            enemy.GetComponent<Target>().TakeDamage(damage);

        }


    }

    public void ultTrigger() {

        ults.TriggerUlt();

    }
}
