using UnityEngine;
using UnityEngine.SceneManagement;
using EasyJoystick;

public class PlayerControler : MonoBehaviour
{

    float jumpButton;

    float horizontalController;

    float moveSpeed;

    public CharacterController controler;

    float jumpHeight;

    public Characters characters;

    public GameObject Player;

    public Rigidbody2D rb;

    bool IsRight = true;

    bool isGrounded;

    public Animator animator;

    public Joystick joystick;

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

        if (characters.HP > 0)
        {

            jumpButton = Input.GetAxisRaw("Jump");

            horizontalController = joystick.Horizontal();

            // Left-right movement

            Vector3 joystickMove = horizontalController * transform.right * moveSpeed;

            controler.Move(joystickMove * Time.deltaTime);

            if (joystick.Horizontal() < 0 && IsRight == true)
            {

                IsRight = false;
                Player.transform.eulerAngles = new Vector3(0, 180, 0);

                if (joystick.Horizontal() < 0)
                {

                    animator.SetFloat("Speed", Mathf.Abs(joystickMove.x));

                }

            }

            if (joystick.Horizontal() > 0 && IsRight == false)
            {

                IsRight = true;
                Player.transform.eulerAngles = new Vector3(0, 0, 0);

                if (joystick.Horizontal() > 0)
                {

                    animator.SetFloat("Speed", Mathf.Abs(joystickMove.x));

                }

            }

            if (horizontalController == 0)
            {

                animator.SetFloat("Speed", Mathf.Abs(joystickMove.x));

            }

            //Jump movement and ground checks

            isGrounded = Physics2D.OverlapCircle(Player.transform.position, 2f, layerMask);

            if (jumpButton != 0)
            {

                Jump();

            }

            if (!isGrounded)
            {

                jumpButton = 1;

            }
            else
            {

                jumpButton = 0;

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
            else if (jumpButton == 0 && isGrounded)
            {

                animator.SetBool("IsJumping", false);
                animator.SetBool("IsGrounded", true);

            }

            // Anti-rotation

            if (rb.rotation != 0) rb.rotation = 0;

        }
        else
        {
            characters.lastScene = SceneManager.GetActiveScene().name;
            Destroy(gameObject);
            SceneManager.LoadScene("Revive");

        }

    }

    void Jump()
    {

        if (isGrounded)
        {

            rb.velocity = Vector2.up * jumpHeight;

        }

    }

}