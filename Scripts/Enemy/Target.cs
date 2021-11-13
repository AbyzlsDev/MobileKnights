using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 100;
    public ScoreManager scoreManager;
    public Characters characters;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0) {

            scoreManager.GiveScore(characters.pointsAfterKill);
            Destroy(gameObject);
        
        }
        
    }

    public void TakeDamage(int damage) {

        health -= damage;
    
    }
}
