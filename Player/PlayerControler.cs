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
    


    void Start()
    {
        moveSpeed = characters.speed;
        jumpHeight = characters.jumpHeight;
        Player.GetComponent<SpriteRenderer>().sprite = characters.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {

            horizontal = Input.GetAxis("Horizontal");
            jumpButton = Input.GetAxis("Jump");

            Vector3 move = transform.right * horizontal;
            Vector3 jump = transform.up * jumpButton;

            controler.Move(move * moveSpeed * Time.deltaTime);
            controler.Move(jump * jumpHeight * Time.deltaTime);

            if (rb.rotation != 0) rb.rotation = 0;

            if (Input.GetAxis("Horizontal") < 0 && IsRight == true)
            {

                IsRight = false;
                Player.transform.eulerAngles = new Vector3(0, 180, 0);

            }

            if (Input.GetAxis("Horizontal") > 0 && IsRight == false)
            {

                IsRight = true;
                Player.transform.eulerAngles = new Vector3(0, 0, 0);

            }

        }
        else {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            

        }


    }


}
