using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOnHit : MonoBehaviour
{
    int damage = 20;
    float velocity = 100f;
    public Rigidbody2D Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        Rigidbody.velocity = transform.right * velocity;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        


        if (collision) {

            Target target = collision.GetComponent<Target>();


            if (target != null) {

                target.TakeDamage(damage);
                
            }

        }
    }

}
