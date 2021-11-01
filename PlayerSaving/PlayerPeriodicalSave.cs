using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPeriodicalSave : MonoBehaviour
{
    private float NextTimeToSave = 0f;

    public Characters characters;

    public GameObject player;

     

    // Update is called once per frame
    void Update()
    {
       
        if (player != null && Time.time >= NextTimeToSave) {

            NextTimeToSave = Time.time + 60f;

            Debug.Log("Saved the game");

            SaveSystem.SavePlayer(characters);


        }
        

        
    }
}
