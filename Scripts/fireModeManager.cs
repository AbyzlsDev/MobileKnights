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
        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            Shoot();
        }

    }

    public void Shoot() {

        switch (characters.fireModeID)
        {
            
            case 1: // melee
                if (Application.platform == RuntimePlatform.WindowsEditor)
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time >= nextTimeToShoot)
                    {

                        nextTimeToShoot = Time.time + 1 / characters.CPS;
                        closedRangeMode.Shoot();


                    }
                }
                else if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer) {

                    if (Time.time >= nextTimeToShoot)
                    {

                        nextTimeToShoot = Time.time + 1 / characters.CPS;
                        closedRangeMode.Shoot();


                    }
                }
                

                break;

            case 2: // ranged
                if (Application.platform == RuntimePlatform.WindowsEditor)
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time >= nextTimeToShoot)
                    {
                        nextTimeToShoot = Time.time + 1f / characters.CPS;

                        rangedFireMode.Shoot();

                    }
                }
                else if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer) {

                    if (Time.time >= nextTimeToShoot)
                    {
                        nextTimeToShoot = Time.time + 1f / characters.CPS;

                        rangedFireMode.Shoot();

                    }
                }
                break;


        }

    }

   
}
