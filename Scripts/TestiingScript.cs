using System;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class TestiingScript : MonoBehaviour
{
    
     PlayerControler playerControler;
     PlayerInventory playerInventory;
     GetEnemiesInScene enemiesInScene;
     Target _target;

     private void Start()
     {
         playerControler = FindObjectOfType<PlayerControler>();
         playerInventory = FindObjectOfType<PlayerInventory>();
         enemiesInScene = FindObjectOfType<GetEnemiesInScene>();
         _target = FindObjectOfType<Target>();
     }


     public void SavePlayer()
    {
        SaveSystem.SavePlayer(playerControler, playerInventory);
        LevelDataSaveSystem.SaveLevelData(enemiesInScene, _target);
        Debug.Log("Pressed the button");
       
        
    }

  

    
}
