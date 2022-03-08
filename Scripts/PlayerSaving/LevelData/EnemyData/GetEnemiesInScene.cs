using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class GetEnemiesInScene : MonoBehaviour
{
    [SerializeField] public List<float> enemyId = new List<float>();
    [SerializeField] public List<float> deadEnemyId = new List<float>();

    private Target[] _targets;
     Target Target;

    private GetEnemiesInScene _getEnemiesInScene;

    private void Awake()
    {
        _targets = FindObjectsOfType<Target>();
        Target = FindObjectOfType<Target>();
        _getEnemiesInScene = FindObjectOfType<GetEnemiesInScene>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
        
        
        for (int i = 0; i < _targets.Length; i++)
        {
            enemyId.Add(_targets[i].GetComponent<Target>().id);
            
            LevelDataSaveSystem.SaveLevelData(_getEnemiesInScene, Target);

        }

    }

    
}
