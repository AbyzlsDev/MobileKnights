using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssultRifle : MonoBehaviour
{
    public GameObject bullet;
    GameObject shotBullet;
    public Transform ShootingPoint;

    float maxAmmo = 20;
    float maxAmmoInReserve = 60;

    private float nextTimeToShoot = 0f;

    float fireRate = 5f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToShoot)
        {
            nextTimeToShoot = Time.time + 1f / fireRate;
            
           Shoot();

        }

    }

   void Shoot() {

       Instantiate(bullet, ShootingPoint.position, Quaternion.identity);
     
    }
}
