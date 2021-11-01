using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoadData : MonoBehaviour
{

   public Characters characters;
    

    private void Awake()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        characters.HP = data.HP;

        characters.score = data.score;

        transform.position = new Vector3(data.position[0], data.position[1], data.position[2]);  
        
    }
}
