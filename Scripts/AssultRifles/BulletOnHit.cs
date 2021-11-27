
using UnityEngine;

public class BulletOnHit : MonoBehaviour
{
    
 
    public AssultRifle shootingScirpt;
    public Animator animator;

    Rigidbody2D rb;

    // Start is called before the first frame update

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        


        if (collision) {

            Target target = collision.GetComponent<Target>();


            if (target != null) {

                
               rb.velocity = Vector3.zero;

               rb.angularVelocity = 0;

                animator.SetBool("hasCollided", true);

                target.TakeDamage(shootingScirpt.damage);

                Destroy(gameObject, GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);

            }

        }
    }

}
