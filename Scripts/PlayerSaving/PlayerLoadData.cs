

using UnityEngine;


public class PlayerLoadData : MonoBehaviour
{

    public PlayerControler playerControler;
    public PlayerInventory playerInventory;




    private void Start()
    { 
        AllData allData = SaveSystem.LoadPlayer();
       

      playerControler.HP = allData.HP;

      playerControler.score = allData.score;

      playerInventory.item = allData.items;


      //transform.position = new Vector3(data.position[0], data.position[1], data.position[2]);

    }
   

}

