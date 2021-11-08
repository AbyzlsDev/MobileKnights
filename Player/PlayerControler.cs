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
    bool isGrounded;

    public Animator animator;

    bool isJumping = false;

    float JumpCounter = 0f;

    bool canDoubleJump;

    float rayDistance = 2f;
    public LayerMask layerMask;





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
           

            horizontal = Input.GetAxisRaw("Horizontal");
            jumpButton = Input.GetAxisRaw("Jump");

            
           
            // Left-right movement

            Vector3 move = transform.right * horizontal * moveSpeed;

            controler.Move(move * Time.deltaTime);

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

            if (Input.GetAxis("Horizontal") == 0)
            {

                animator.SetFloat("Speed", Mathf.Abs(move.x));

            }

            //Jump movement and ground checks

            isGrounded = Physics2D.OverlapCircle(Player.transform.position, 2f, layerMask);


            if (jumpButton != 0 && isGrounded) {
           
                Jump();

            }

           

            if (jumpButton != 0 && !isGrounded)
            {

                animator.SetBool("IsJumping", true);
                animator.SetBool("IsGrounded", false);

            }
            else if (jumpButton == 0 && !isGrounded)
            {

                animator.SetBool("IsJumping", false);
                animator.SetBool("IsGrounded", false);

            }
            else if (jumpButton == 0 && isGrounded) {

                animator.SetBool("IsJumping", false);
                animator.SetBool("IsGrounded", true);

            }

            // Anti-rotation

            if (rb.rotation != 0) rb.rotation = 0;


        }
        else
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


        }


    }

    void Jump() {

        rb.velocity = Vector2.up * jumpHeight;

    }


}