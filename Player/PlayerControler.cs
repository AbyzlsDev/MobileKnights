using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{

    float horizontal;
    float jumpButton;
    float moveSpeed;
    public CharacterController controler;
    float jumpHeight;
    public Characters characters;
    public GameObject Player;
    public Rigidbody2D rb;
    bool IsRight = true;
  
    




    public Animator animator;

   



    void Start()
    {
        moveSpeed = characters.speed;
        jumpHeight = characters.jumpHeight;
        Player.GetComponent<SpriteRenderer>().sprite = characters.sprite;
        GetComponentInChildren<Animator>().runtimeAnimatorController = characters.animationController;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {

            horizontal = Input.GetAxis("Horizontal");
            jumpButton = Input.GetAxisRaw("Jump");

            Vector3 move = transform.right * horizontal * moveSpeed;
            Vector3 jump = transform.up * jumpButton * jumpHeight;

            controler.Move(move * Time.deltaTime);

            controler.Move(jump * Time.deltaTime);

            Debug.Log(controler.isGrounded);

            if (rb.rotation != 0) rb.rotation = 0;

            if (Input.GetAxis("Horizontal") < 0 && IsRight == true)
            {

                IsRight = false;
                Player.transform.eulerAngles = new Vector3(0, 180, 0);
                animator.SetFloat("Speed", Mathf.Abs(move.x));

            }

            if (Input.GetAxis("Horizontal") > 0 && IsRight == false)
            {

                IsRight = true;
                Player.transform.eulerAngles = new Vector3(0, 0, 0);
                animator.SetFloat("Speed", Mathf.Abs(move.x));
            }

            if (Input.GetAxis("Horizontal") == 0) {

                animator.SetFloat("Speed", Mathf.Abs(move.x));

            }

            

            if (Input.GetAxis("Jump") != 0)
            {
                
                animator.SetBool("IsJumping", true);

            }
            else
            {
                
                animator.SetBool("IsJumping", false);

            } // add a viking jump animation
            //finish wizard and viking animations
            

            

        }
        else {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            

        }


    }


    

}
