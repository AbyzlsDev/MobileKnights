
using UnityEngine;

public class LoadEnemiesInList : MonoBehaviour
{
     public GetEnemiesInScene enemiesInScene; 
     public Target _target;

    void Awake()
    {
        enemiesInScene = FindObjectOfType<GetEnemiesInScene>();
        _target = FindObjectOfType<Target>();
        
        AllEnemyData allEnemyData = LevelDataSaveSystem.LoadLevelData();

        _target.health = allEnemyData._health;

        enemiesInScene.deadEnemyId = allEnemyData._deadEnemId;
    }

    

    
}
