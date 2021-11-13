using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssultRifle : MonoBehaviour
{
    public GameObject bullet;
    public int damage = 20;
    float velocity = 20f;
    

    public Transform ShootingPoint;

   public void Shoot() {

        GameObject bulletInstance = Instantiate(bullet, ShootingPoint.position, Quaternion.identity);

        bulletInstance.GetComponent<Rigidbody2D>().velocity = transform.right * velocity;

        Destroy(bulletInstance, 2);
     
    }
}
