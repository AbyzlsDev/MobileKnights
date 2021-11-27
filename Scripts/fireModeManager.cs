using UnityEngine;
using UnityEngine.UI;

public class fireModeManager : MonoBehaviour
{
    public AssultRifle rangedFireMode;
    public CharacterMeleeDamage closedRangeMode;
    public Characters characters;

    public Button attackButton;

    float nextTimeToShoot = 0f;

    

    // Update is called once per frame
    void Update()
    {
        Shoot();


    }

    public void Shoot() {

        switch (characters.fireModeID)
        {

            case 1: // melee

                if (Input.GetMouseButtonDown(0) && Time.time >= nextTimeToShoot)
                {

                    nextTimeToShoot = Time.time + 1 / characters.CPS;
                    closedRangeMode.Shoot();


                }

                break;

            case 2: // ranged

                if (Input.GetMouseButtonDown(0) && Time.time >= nextTimeToShoot)
                {
                    nextTimeToShoot = Time.time + 1f / characters.CPS;

                    rangedFireMode.Shoot();

                }
                break;


        }

    }

   
}
