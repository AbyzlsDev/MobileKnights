using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AllEnemyData
{
  
  
  public List<float> _deadEnemId = new List<float>();

  public float  _health;
  
    public AllEnemyData(GetEnemiesInScene enemiesInScene, Target target)
    {

        _health = target.health;
        
        _deadEnemId = enemiesInScene.deadEnemyId;

    }

    
}
