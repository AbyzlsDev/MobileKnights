using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public bool hasDetectedPlayer = false;
    public Transform player;
    Rigidbody2D enemyRB;
    float enemyMoveSpeed = 5f;
    Vector3 positionSet;
    public LayerMask layerMask;
    public Transform[] transforms;
    public int transfromsIndex;
   
  




    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();



    }

    // Update is called once per frame
    void Update()
    {
        

        if (enemyRB.rotation != 0) enemyRB.rotation = 0;

       

        RequireNewPosition();



    }

    void FixedUpdate()
    {
        switch (hasDetectedPlayer) {

            case true:

                MoveEnemyToPlayer();

                break;

            default:

                MoveEnemyInRange();

                break;
        
        }
       

    }

     void MoveEnemyToPlayer() {

        if (player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, enemyMoveSpeed * Time.deltaTime);
        }

        else  {

            hasDetectedPlayer = false;
            transfromsIndex = 0;


        }

    }

    void MoveEnemyInRange() {

        transform.position = Vector2.MoveTowards(transform.position, positionSet, enemyMoveSpeed * Time.deltaTime);
       
    }

    void RequireNewPosition() {

        Vector3 newPosition = new Vector3(transforms[transfromsIndex].position.x, transform.position.y, transform.position.z);

       

        positionSet = newPosition;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transfromsIndex == 0) transfromsIndex++;
        else  transfromsIndex --;


    }

  
}

    

