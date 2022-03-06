using UnityEngine.SceneManagement;
using UnityEngine;



public class RevivePlayer : MonoBehaviour
{
   
    public void CharactersDef(Characters characters, PlayerControler playerControler)
    {

       
      
        PlayerInventory playerInventory = new PlayerInventory();

        playerControler.HP = characters.maxHP;


        /*characters.positionX = default;
        characters.positionY = default;
        characters.positionZ = default;*/

       SaveSystem.SavePlayer(playerControler, playerInventory);
        

        SceneManager.LoadScene(characters.lastScene);

    }

   

}
