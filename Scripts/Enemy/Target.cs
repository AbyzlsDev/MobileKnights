
using System;
using System.Security.Cryptography;
using UnityEngine;

[System.Serializable]
public class Target : MonoBehaviour
{
    public float health; 
    ScoreManager scoreManager;
    public Characters characters;
    public float id; 
    public GetEnemiesInScene EnemiesInScene;

    private void Awake()
    {

        EnemiesInScene = FindObjectOfType<GetEnemiesInScene>();
        
        id = gameObject.GetInstanceID();
        
        

    }

    private void Start()
    {
        for(int i = 0; i < EnemiesInScene.deadEnemyId.Count; i++)
        {

            if (id == EnemiesInScene.deadEnemyId[i])
            {
                    
                Destroy(gameObject);
                EnemiesInScene.enemyId.Remove(id);

            }

                
        }
        
    }


    // Update is called once per frame
    void Update()
    {

        if (health <= 0) {

            scoreManager.GiveScore(characters.pointsAfterKill);
            
            EnemiesInScene.deadEnemyId.Add(id);

            EnemiesInScene.enemyId.Remove(id);
            
            LevelDataSaveSystem.SaveLevelData(EnemiesInScene, this);
            
            Destroy(gameObject);
            
            
        
        } 
        
    }

    private void FixedUpdate()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        
    }


    public void TakeDamage(int damage) {

        health -= damage;
    
    }
}
