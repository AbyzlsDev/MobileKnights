using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireModeManager : MonoBehaviour
{
    public AssultRifle rangedFireMode;
    public CharacterMeleeDamage closedRangeMode;
    public Characters characters;

    float nextTimeToShoot = 0f;

    // Update is called once per frame
    void Update()
    {
        switch (characters.fireModeID) {

            case 1: // melee

                if (Input.GetButtonDown("Fire1") && Time.time >= nextTimeToShoot)
                {

                    nextTimeToShoot = Time.time + 1 / characters.CPS;
                    closedRangeMode.Shoot();


                }

                break;

            case 2: // ranged

                if (Input.GetButton("Fire1") && Time.time >= nextTimeToShoot)
                {
                    nextTimeToShoot = Time.time + 1f / characters.CPS;

                    rangedFireMode.Shoot();

                }
                break;
        
        
        }
        
    }
}
