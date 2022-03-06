using UnityEngine;

public class PlayerPeriodicalSave : MonoBehaviour
{
    private float NextTimeToSave = 0f;

    public PlayerControler playerControler;
    public PlayerInventory playerInventory;

    public GameObject player;

     

    // Update is called once per frame
    void Update()
    {
       
        if (player != null && Time.time >= NextTimeToSave) {

            NextTimeToSave = Time.time + 60f;

            SaveSystem.SavePlayer(playerControler, playerInventory);

            Debug.Log("Saved the game");

        }
        

        
    }
}
