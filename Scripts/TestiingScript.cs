using UnityEngine;
using UnityEngine.UI;

public class TestiingScript : MonoBehaviour
{
    
    public PlayerControler playerControler;
    public PlayerInventory playerInventory;

    

    public void SavePlayer()
    {
        Debug.Log("Pressed the button");
        SaveSystem.SavePlayer(playerControler, playerInventory);
        
    }

  

    
}
