using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UltimateMoves : MonoBehaviour
{

    public Characters Player;
    public Characters Viking;
    public Characters Wizard;
    public Characters Rouge;

    public Transform player;

    CharacterMeleeDamage CharacterMeleeDamage;

    float nextTimeToUse;

    void Start()
    {
        CharacterMeleeDamage = GetComponent<CharacterMeleeDamage>();

        
    }

    

    
    public void TriggerUlt()
    {
        if (Time.time > nextTimeToUse)
        {
            switch (Player.UltNumber)
            {
                case 1:

                    StartCoroutine(VikingUlt());

                    nextTimeToUse = Time.time + 20f;

                    break;

                case 2:

                   WizardUlt();

                    nextTimeToUse = Time.time + 50f;

                    break;
            }


        }
        


    }

    public IEnumerator VikingUlt()
    {

        Player.damage += 70;
        Player.CPS = 25f;

        yield return new WaitForSeconds(5);

        Player.damage = Viking.damage;
        Player.CPS = Viking.CPS;



    }


    public void WizardUlt()
    {
        

        Collider2D[] hits = Physics2D.OverlapCircleAll(new Vector3(player.position.x, player.position.y / 2, 0), Player.AttackRange + 3f, CharacterMeleeDamage.layerMask);

        foreach (Collider2D enemy in hits)
        {
            enemy.GetComponent<Target>().TakeDamage(1000000000); //Damage put as a placeholder, might be a subject to change due to change in damage calculaton

        }

    }

    //add Rogue ult

    //add UI to the Ults

}
